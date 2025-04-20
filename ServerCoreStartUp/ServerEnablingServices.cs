using EasyData.Services;
using Korzh.DbUtils;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.FileProviders;
using MirrorSharp;
using MirrorSharp.AspNetCore;
using MonacoProvider;
using MonacoProvider.Api;
using Snickler.RSSCore.Caching;
using Snickler.RSSCore.Extensions;
using Snickler.RSSCore.Models;
using System.Collections.Immutable;

namespace EasyITCenter.ServerCoreConfiguration {

    /// <summary>
    /// Server Core Enabling Settings of Security, API Communications, Technologies, Modules,Rules,
    /// Rights, Rules, Rights, Conditions, Cors, Cookies, Formats, Services, Logging, etc..
    /// </summary>
    public class ServerEnablingServices {



        /// <summary>
        /// Enable Automatic Js,Css Minification
        /// </summary>
        /// <param name="app"></param>
        internal static void EnableAutoMinify(ref IApplicationBuilder app) {
            if (SrvConfig.EnableAutoMinify) { app.UseWebOptimizer(); }
        }
               

        /// <summary>
        /// Enable Server Logging in Debug Mode
        /// </summary>
        internal static void EnableLogging(ref IApplicationBuilder app) {
                if (SrvRuntime.DebugMode) { app.UseHttpLogging(); }
         }


        /// <summary>
        /// Server Cors Configuration
        /// </summary>
        internal static void EnableCors(ref IApplicationBuilder app) {
            if (SrvConfig.ServerCorsEnabled) {
                app.UseCors(x => {
                    List<ServerCorsDefAllowedOriginList> data;
                    using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {
                        data = new EasyITCenterContext().ServerCorsDefAllowedOriginLists.Where(a => a.Active).ToList();
                    }

                    if (SrvConfig.ServerCorsAllowAnyHeader) { x.AllowAnyHeader(); }
                    if (SrvConfig.ServerCorsAllowAnyMethod) { x.AllowAnyMethod(); }
                    if (SrvConfig.ServerCorsAllowCredentials) { x.AllowCredentials(); }
                    if (SrvConfig.ServerCorsAllowAnyOrigin) { x.AllowAnyOrigin(); }
                    else if (data.Any()) { string[] allowedDomains = data.Select(a => a.AllowedDomain).ToArray(); x.WithOrigins(allowedDomains); }
                });
            };
        }

        /// <summary>
        /// Server WebSocket Configuration
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        internal static void EnableWebSocket(ref IApplicationBuilder app) {
            if (SrvConfig.WebSocketEngineEnabled) {
                var webSocketOptions = new WebSocketOptions() {
                    KeepAliveInterval = TimeSpan.FromHours(SrvConfig.WebSocketTimeoutMin),
                };
                app.UseWebSockets(webSocketOptions);
            }
        }


        //RssFeed Support
        internal static void EnableRssFeed(ref IApplicationBuilder app) {
            if (SrvConfig.WebRSSFeedsEnabled) {
                app.UseRSSFeed("/feed", new RSSFeedOptions {
                    Title = SrvConfig.ConfigCoreServerRegisteredName + " RSS Feed",
                    Copyright = "2023 " + SrvConfig.ConfigCoreServerRegisteredName,
                    Description = "RSS Feed with Company Portfolio",
                    ManagingEditor = SrvConfig.ConfigManagerEmailAddress,
                    Webmaster = SrvConfig.EmailerServiceEmailAddress,
                    Url = new Uri(SrvConfig.ServerPublicUrl),
                    Caching = new MemoryCacheProvider { CacheDuration = TimeSpan.FromDays(5), Key = "RSSCacheKey" }
                });
            }
        }


        /// <summary>
        /// Server Endpoints Configuration
        /// </summary>
        internal static void EnableEndpoints(ref IApplicationBuilder app) {

            app.UseEndpoints(endpoints => {

                //EasyData Support
                if (SrvConfig.ModuleWebDataManagerEnabled) { endpoints.MapEasyData(options => { options.UseDbContext<EasyITCenterContext>(); }); }


                endpoints.MapControllers();

                if (SrvConfig.WebRazorPagesEngineEnabled) {
                    endpoints.MapRazorPages();
                    //endpoints.MapControllerRoute(name: "DevPortal", pattern: "{controller=DevPortal}/{action=Index}/{id?}");
                    //endpoints.MapControllerRoute(name: "WebAdmin",pattern: "{controller=WebAdmin}/{action=Index}/{id?}");
                    endpoints.MapControllerRoute(name: "RazorPages", pattern: "{controller=ServerCorePages}/{action=Index}/{id?}");
                }

                
                //https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-8.0
                //VYTVORIT AGENDU NA VLASTNI API PO RESETU


                //HeathService Support
                if (SrvConfig.ModuleHealthServiceEnabled) {
                    endpoints.MapHealthChecks("/HealthResultService",
                        new HealthCheckOptions() {
                            Predicate = p => true,
                            ResultStatusCodes = { [HealthStatus.Healthy] = StatusCodes.Status200OK, [HealthStatus.Degraded] = StatusCodes.Status500InternalServerError, [HealthStatus.Unhealthy] = StatusCodes.Status503ServiceUnavailable },
                            ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse,
                            AllowCachingResponses = false
                        });
                }

                //Monaco Support
                endpoints.MapPost("/MonacoCompletion/{0}", async (e) =>
                {
                    using var reader = new StreamReader(e.Request.Body);
                    string text = await reader.ReadToEndAsync();
                    if (text != null) {
                        if (e.Request.Path.Value?.EndsWith("complete") == true) {
                            var tabCompletionRequest = JsonSerializer.Deserialize<TabCompletionRequest>(text);
                            var tabCompletionResults = await CompletitionRequestHandler.Handle(tabCompletionRequest);
                            await JsonSerializer.SerializeAsync(e.Response.Body, tabCompletionResults); return;
                        }
                        else if (e.Request.Path.Value?.EndsWith("signature") == true) {
                            var signatureHelpRequest = JsonSerializer.Deserialize<SignatureHelpRequest>(text);
                            var signatureHelpResult = await CompletitionRequestHandler.Handle(signatureHelpRequest);
                            await JsonSerializer.SerializeAsync(e.Response.Body, signatureHelpResult); return;
                        }
                        else if (e.Request.Path.Value?.EndsWith("hover") == true) {
                            var hoverInfoRequest = JsonSerializer.Deserialize<HoverInfoRequest>(text);
                            var hoverInfoResult = await CompletitionRequestHandler.Handle(hoverInfoRequest);
                            await JsonSerializer.SerializeAsync(e.Response.Body, hoverInfoResult); return;
                        }
                        else if (e.Request.Path.Value?.EndsWith("codeCheck") == true) {
                            var codeCheckRequest = JsonSerializer.Deserialize<CodeCheckRequest>(text);
                            var codeCheckResults = await CompletitionRequestHandler.Handle(codeCheckRequest);
                            await JsonSerializer.SerializeAsync(e.Response.Body, codeCheckResults); return;
                        }
                    }
                    e.Response.StatusCode = 405;
                });



                //MirrorSharp Support
                if (SrvConfig.ModuleCSharpCodeBuilder) { endpoints.MapMirrorSharp("/mirrorsharp", new MirrorSharpOptions { SelfDebugEnabled = true, IncludeExceptionDetails = true  }
                .SetupCSharp(o => {
                    o.AddMetadataReferencesFromFiles(FileOperations.GetPathFiles(SrvRuntime.Startup_path, "*.dll", SearchOption.TopDirectoryOnly).ToArray());
                    // = ..MetadataReferences = GetAllReferences().ToImmutableList();
                })); }

                /*
                static IEnumerable<MetadataReference> GetAllReferences() {
                    yield return ReferenceAssembly("System.Runtime");
                    //yield return ReferenceAssembly("System.Runtime");
                    //yield return ReferenceAssembly("System.Collections");
                    var assembly = typeof(IScriptGlobals).Assembly;
                    yield return MetadataReference.CreateFromFile(assembly.Location);
                    foreach (var reference in assembly.GetReferencedAssemblies()) {
                        yield return ReferenceAssembly(reference.Name!);
                    }
                }

                static MetadataReference ReferenceAssembly(string name) {
                    var rootPath = Path.Combine(AppContext.BaseDirectory);
                    var assemblyPath = Path.Combine(rootPath, name + ".dll");
                    var documentationPath = Path.Combine(rootPath, name + ".xml");
                    return MetadataReference.CreateFromFile(assemblyPath, documentation: null);
                }
                */
            });
            
            //MirrorSharp Support
            if (SrvConfig.ModuleCSharpCodeBuilder) { app.MapMirrorSharp("/mirrorsharp"); }

            //HeathService Support
            if (SrvConfig.ModuleHealthServiceEnabled) {
                app.UseHealthChecks("/HealthResultService");
                app.UseMiddleware<ServerCycleTaskMiddleware>();
                app.UseHealthChecksUI(setup => {
                    setup.UIPath = SrvConfig.ModuleHealthServicePath.StartsWith("/") ? SrvConfig.ModuleHealthServicePath : "/" + SrvConfig.ModuleHealthServicePath;
                    setup.AsideMenuOpened = true;
                    setup.PageTitle = SrvConfig.ConfigCoreServerRegisteredName;
                    setup.AddCustomStylesheet(Path.Combine(SrvRuntime.SrvIntegrated_path, "server-modules", "HealthCheck", "HealthChecksUI.css"));
                });
            }

          
        }
    }
}