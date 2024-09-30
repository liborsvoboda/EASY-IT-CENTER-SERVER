using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using ServiceStack;
using ServiceStack.IO;
using ServiceStack.Script;
using ServiceStack.Text;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using ServiceStack.Configuration;
using Funq;
using ServiceStack.Api.OpenApi;
using ServiceStack.MiniProfiler.Data;
using ServiceStack.Mvc;
using ServiceStack.Validation;
using EasyITCenter.ServerCoreStructure;
using StackExchange.Profiling.Data;
using ServiceStack.MiniProfiler;
using StackExchange.Profiling;
using System.Data.Common;
using ServiceStack.Auth;

namespace EasyITCenter.SharpScript
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("#Script Pages", typeof(ScriptServices).Assembly) { }

        public ScriptContext LinqContext;

        public override void Configure(Container container)
        {
            SetConfig(new HostConfig {
                DebugMode = AppSettings.Get("DebugMode", Env.IsWindows),

                //LIBOR ADD
                EnableFeatures = Feature.All,
                AllowPartialResponses = true,
                //List string MAYBE users AllowFilePaths = true,
                AllowSessionCookies = true,
                EnableAutoHtmlResponses = true,
                ForbiddenPaths = new List<string>() { SrvRuntime.SrvPrivate_path }
                

            });
            //LIBOR ADD
            Plugins.Add(new AdminDatabaseFeature());

            Plugins.Add(new ServiceStack.Api.OpenApi.OpenApiFeature());
            Plugins.Add(new OpenApiFeature());
            Plugins.Add(new RazorFormat());
            Plugins.Add(new RequestLogsFeature());
            Plugins.Add(new PostmanFeature());
            Plugins.Add(new CorsFeature());

            Plugins.Add(new ValidationFeature());
            //container.RegisterValidators(typeof(ContactsServices).Assembly);

            


            var profiler = MiniProfiler.Current;
            container.Register<IDbConnectionFactory>(
                c => new OrmLiteConnectionFactory(SrvRuntime.SrvPrivate_path + "/Databases/ServiceStack.db3".MapHostAbsolutePath(), SqliteDialect.Provider) {
                    ConnectionFilter = x => new ProfiledDbConnection((x.ConnectionString = "Data Source=ServiceStack.db3;Cache=Shared").ToDbConnection() as DbConnection, profiler)
                });

          

            var path = MapProjectPath("~/server-integrated/razor-pages/servicestack/assets/js/customers.json");
            var json = File.ReadAllText(path);
            TemplateQueryData.Customers = json.FromJson<List<Customer>>();

            container.Register<ICustomers>(c => new Customers(TemplateQueryData.Customers));
            container.Register<IDbConnectionFactory>(c => new OrmLiteConnectionFactory(":memory:", SqliteDialect.Provider));

            using (var db = container.Resolve<IDbConnectionFactory>().Open())
            {
                db.CreateTable<Order>();
                db.CreateTable<Customer>();
                db.CreateTable<Product>();
                TemplateQueryData.Customers.Each(x => db.Save(x, references:true));
                db.InsertAll(TemplateQueryData.Products);

                db.CreateTable<Quote>();
                db.Insert(new Quote { Id = 1, Url = "https://gist.githubusercontent.com/gistlyn/0ab7494dfbff78466ef622d501662027/raw/b3dd1e9f8e82c169a32829071aa7f761c6494843/quote.md" });
            }

            
            Plugins.Add(new HotReloadFeature());

            //Plugins.Add(new AutoQueryFeature { MaxLimit = 100 });
            Plugins.Add(new AutoQueryDataFeature { MaxLimit = 100 }
                .AddDataSource(ctx => ctx.ServiceSource<GithubRepo>(ctx.Dto.ConvertTo<GetGithubRepos>(), 
                    HostContext.Cache, TimeSpan.FromMinutes(10)))
            );

            var customFilters = new CustomScriptMethods();
            Plugins.Add(new SharpPagesFeature {
                ScriptLanguages = { ScriptLisp.Language },
                ScriptMethods = { 
                    customFilters,
                    new DbScriptsAsync()
                },
                FilterTransformers = {
                    ["convertScriptToCodeBlocks"] = GitHubMarkdownScripts.convertScriptToCodeBlocks,
                    ["convertScriptToLispBlocks"] = GitHubMarkdownScripts.convertScriptToLispBlocks,
                },
                Args = {
                    ["products"] = TemplateQueryData.Products
                },
                ScriptTypes = {
                    typeof(Ints),
                    typeof(Adder),
                    typeof(StaticLog),
                    typeof(InstanceLog),
                    typeof(GenericStaticLog<>),
                },
                RenderExpressionExceptions = true,
                MetadataDebugAdminRole = RoleNames.AllowAnon,
                ExcludeFiltersNamed = { "dbExec" }
            });

            AfterInitCallbacks.Add(host => {
                var feature = GetPlugin<SharpPagesFeature>();

                var files = GetVirtualFileSources().First(x => x is FileSystemVirtualFiles);
                foreach (var file in files.GetDirectory("docs").GetAllMatchingFiles("*.html"))
                {
                    var page = feature.GetPage(file.VirtualPath).Init().Result;
                    if (page.Args.TryGetValue("order", out object order) && page.Args.TryGetValue("title", out object title))
                    {
                        customFilters.DocsIndex[int.Parse((string)order)] = new KeyValuePair<string,string>(GetPath(file.VirtualPath), (string)title);
                    }
                }

                foreach (var file in files.GetDirectory("sharp-apps").GetAllMatchingFiles("*.html"))
                {
                    var page = feature.GetPage(file.VirtualPath).Init().Result;
                    if (page.Args.TryGetValue("order", out object order) && page.Args.TryGetValue("title", out object title))
                    {
                        customFilters.AppsIndex[int.Parse((string)order)] = new KeyValuePair<string,string>(GetPath(file.VirtualPath), (string)title);
                    }
                }

                foreach (var file in files.GetDirectory("scode").GetAllMatchingFiles("*.html"))
                {
                    var page = feature.GetPage(file.VirtualPath).Init().Result;
                    if (page.Args.TryGetValue("order", out object order) && page.Args.TryGetValue("title", out object title))
                    {
                        customFilters.CodeIndex[int.Parse((string)order)] = new KeyValuePair<string,string>(GetPath(file.VirtualPath), (string)title);
                    }
                }

                foreach (var file in files.GetDirectory("lisp").GetAllMatchingFiles("*.html"))
                {
                    var page = feature.GetPage(file.VirtualPath).Init().Result;
                    if (page.Args.TryGetValue("order", out object order) && page.Args.TryGetValue("title", out object title))
                    {
                        customFilters.LispIndex[int.Parse((string)order)] = new KeyValuePair<string,string>(GetPath(file.VirtualPath), (string)title);
                    }
                }

                foreach (var file in files.GetDirectory("usecases").GetAllMatchingFiles("*.html"))
                {
                    var page = feature.GetPage(file.VirtualPath).Init().Result;
                    if (page.Args.TryGetValue("order", out object order) && page.Args.TryGetValue("title", out object title))
                    {
                        customFilters.UseCasesIndex[int.Parse((string)order)] = new KeyValuePair<string,string>(GetPath(file.VirtualPath), (string)title);
                    }
                }

                foreach (var file in files.GetDirectory("linq").GetAllMatchingFiles("*.html"))
                {
                    var page = feature.GetPage(file.VirtualPath).Init().Result;
                    if (page.Args.TryGetValue("order", out object order) && page.Args.TryGetValue("title", out object title))
                    {
                        customFilters.LinqIndex[int.Parse((string)order)] = new KeyValuePair<string,string>(GetPath(file.VirtualPath), (string)title);
                    }
                }

                var protectedScriptNames = new HashSet<string>(ScriptMethodInfo.GetMethodsAvailable(typeof(ProtectedScripts)).Map(x => x.Name));

                LinqContext = new ScriptContext {
                    ScriptLanguages = { ScriptLisp.Language },
                    Args = {
                        [ScriptConstants.DefaultDateFormat] = "yyyy/MM/dd",
                        ["products"] = TemplateQueryData.Products,
                        ["products-list"] = Lisp.ToCons(TemplateQueryData.Products),
                        ["customers"] = TemplateQueryData.Customers,
                        ["customers-list"] = Lisp.ToCons(TemplateQueryData.Customers),
                        ["comparer"] = new CaseInsensitiveComparer(),
                        ["anagramComparer"] = new AnagramEqualityComparer(),
                    },
                    ScriptTypes = {
                        typeof(DateTime),
                        typeof(CaseInsensitiveComparer),
                        typeof(AnagramEqualityComparer),
                    },
                    ScriptMethods = {
                        new ProtectedScripts()
                    },
                };
                protectedScriptNames.Each(x => LinqContext.ExcludeFiltersNamed.Add(x));
                LinqContext.Init();
            });
        }

        public string GetPath(string virtualPath)
        {
            var path = "/" + virtualPath.LastLeftPart('.');
            if (path.EndsWith("/index"))
                path = path.Substring(0, path.Length - "index".Length);

            return path;
        }
    }

    public class Quote
    {
        public int Id { get; set; }
        public string Url { get; set; }
    }
}
