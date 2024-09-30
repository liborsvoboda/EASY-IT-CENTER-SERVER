using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Microsoft.EntityFrameworkCore.Scaffolding;
using PuppeteerExtraSharp.Plugins;
using Scriban.Syntax;
using ServiceStack;
using ServiceStack.Data;
using ServiceStack.IO;
using ServiceStack.OrmLite;
using ServiceStack.Script;
using RouteAttribute = ServiceStack.RouteAttribute;

namespace EasyITCenter.SharpScript
{

    /// <summary>
    /// Product Service
    /// </summary>
    public class ProductsServices : Service {
        public object Any(ViewProducts request) =>
            new PageResult(Request.GetCodePage("products")) {
                Args = {
                    ["products"] = TemplateQueryData.Products
                }
            };
    }


    /// <summary>
    /// AutoDataQueryServices
    /// </summary>
    public class AutoDataQueryServices : Service
    {
        public object Any(GetGithubRepos request)
        {
            Dictionary<int, GithubRepo>? map = new Dictionary<int, GithubRepo>();
            GetUserRepos(request.UserName).Each(x => map[x.Id] = x);
            GetOrgRepos(request.UserName).Each(x => map[x.Id] = x);
            GetUserOrgs(request.UserName).Each(org =>
                GetOrgRepos(org.Login)
                    .Each(repo => map[repo.Id] = repo));

            return map.Values.ToList();
        }

        public List<GithubOrg> GetUserOrgs(string githubUsername) => 
            GetJson<List<GithubOrg>>($"users/{githubUsername}/orgs");
        public List<GithubRepo> GetUserRepos(string githubUsername) => 
            GetJson<List<GithubRepo>>($"users/{githubUsername}/repos");
        public List<GithubRepo> GetOrgRepos(string githubOrgName) => 
            GetJson<List<GithubRepo>>($"orgs/{githubOrgName}/repos");
        
        public T GetJson<T>(string route) 
        {
            try {
                return "https://api.github.com".CombineWith(route)
                    .GetJsonFromUrl(requestFilter: req => req.With(c => c.UserAgent = nameof(AutoDataQueryServices)))
                    .FromJson<T>();
            } catch(Exception) { return default(T); }
        }
    }



    /// <summary>
    /// CustomerServices
    /// </summary>
    public class CustomerServices : Service {
        public ISharpPages Pages { get; set; }

        public object Any(ViewCustomer request) =>
            new PageResult(Pages.GetPage("examples/customer")) {
                Model = TemplateQueryData.GetCustomer(request.Id)
            };
    }


    /// <summary>
    /// LinqServices
    /// </summary>
    [ReturnExceptionsInJson]
    public class LinqServices : Service {
        public async Task<object> Any(EvaluateLinq request) {
            ScriptContext? context = ((AppHost)AppHost.Instance).LinqContext;

            foreach (var entry in request.Files.Safe()) {
                context.VirtualFiles.WriteFile(entry.Key, entry.Value);
            }

            var page = request.Lang == "code"
                ? context.CodeSharpPage(request.Code)
                : request.Lang == "lisp"
                    ? context.LispSharpPage(request.Code)
                    : context.OneTimePage(request.Code);

            var pageResult = new PageResult(page);
            return await pageResult.RenderToStringAsync();
        }
    }


    /// <summary>
    /// IntrospectStateServices
    /// </summary>
    public class IntrospectStateServices : Service {
        public object Any(IntrospectState request) {
            ScriptContext? context = new ScriptContext {
                ScanTypes = { typeof(StateScriptMethods) }, //Autowires (if needed)
                RenderExpressionExceptions = true
            }.Init();

            return new PageResult(context.OneTimePage(request.Page));
        }
    }


    /// <summary>
    /// ScriptServices
    /// </summary>
    [ReturnExceptionsInJson]
    public class ScriptServices : Service {
        public async Task<string> Any(EvaluateScripts request) {
            var context = new ScriptContext {
                ScriptMethods = {
                    new ProtectedScripts(),
                },
                ExcludeFiltersNamed = { "fileWrite", "fileAppend", "fileDelete", "dirDelete" }
            }.Init();

            foreach (var entry in request.Files.Safe()) {
                context.VirtualFiles.WriteFile(entry.Key, entry.Value);
            }

            var pageResult = new PageResult(context.GetPage(request.Page ?? "page"));

            foreach (var entry in request.Args.Safe()) {
                pageResult.Args[entry.Key] = entry.Value;
            }

            return await pageResult.RenderToStringAsync(); // render to string so [ReturnExceptionsInJson] can detect Exceptions and return JSON
        }

        public async Task<string> Any(EvaluateScript request) {
            var context = new ScriptContext {
                DebugMode = false,
                ScriptLanguages = { ScriptLisp.Language },
                ScriptMethods = {
                    new DbScriptsAsync(),
                    new AutoQueryScripts(),
                    new ServiceStackScripts(),
                    new CustomScriptMethods(),
                    //LIBOR ADD
                    new LispScriptMethods(),
                },
                Plugins = {
                    new ServiceStackScriptBlocks(),
                    new MarkdownScriptPlugin(),
                    //LIBOR ADD
                    new GitHubPlugin(), 
                    new TypeScriptPlugin(),
                    new MarkdownTemplatePlugin()
                }
            };

            //Register any dependencies filters need:
            context.Container.AddSingleton(() => base.GetResolver().TryResolve<IDbConnectionFactory>());
            context.Init();
            var pageResult = new PageResult(context.OneTimePage(request.Template)) {
                Args = base.Request.GetScriptRequestParams(importRequestParams: true)
            };
            return await pageResult.RenderToStringAsync(); // render to string so [ReturnExceptionsInJson] can detect Exceptions and return JSON
        }

        public object Any(EvalExpression request) {
            if (string.IsNullOrWhiteSpace(request.Expression))
                return new EvalExpressionResponse();

            var args = new Dictionary<string, object>();
            foreach (String name in Request.QueryString.AllKeys) {
                if (name.EqualsIgnoreCase("expression"))
                    continue;

                var argExpr = Request.QueryString[name];
                var argValue = JS.eval(argExpr);
                args[name] = argValue;
            }

            var scope = JS.CreateScope(args: args);
            var expr = JS.expression(request.Expression.Trim());

            var response = new EvalExpressionResponse {
                Result = ScriptLanguage.UnwrapValue(expr.Evaluate(scope)),
                Tree = expr.ToJsAstString(),
            };
            return response;
        }
    }


    /// <summary>
    /// Email Template Service
    /// </summary>
    public class EmailTemplatesServices : Service {
        public ICustomers Customers { get; set; }

        public object Any(PreviewHtmlEmail request) {
            var customer = Customers.GetCustomer(request.PreviewCustomerId)
                ?? Customers.GetAllCustomers().First();

            ScriptContext? context = new ScriptContext {
                PageFormats = { new MarkdownPageFormat() },
                Args = {
                    ["customer"] = customer,
                    ["order"] = customer.Orders.LastOrDefault(),
                }
            }.Init();

            context.VirtualFiles.WriteFile("email.md", request.EmailTemplate);
            context.VirtualFiles.WriteFile("layout.html", request.HtmlTemplate);

            var textEmail = new PageResult(context.GetPage("email")).Result;
            var htmlEmail = new PageResult(context.GetPage("email")) {
                Layout = "layout",
                PageTransformers = { MarkdownPageFormat.TransformToHtml }
            }.Result;

            return new PreviewHtmlEmailResponse {
                TextEmail = textEmail,
                HtmlEmail = htmlEmail,
            };
        }
    }
}