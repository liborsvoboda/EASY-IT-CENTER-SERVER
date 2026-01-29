# Excel on Web
https://github.com/jspreadsheet/ce


# NetCore Electron with Metro
https://github.com/taurenshaman/electron-net-demo/tree/master  Ideal For Standalone Touch Panel


# Double Path for saving Project + StartupFolder
System.IO.File.WriteAllText(Path.Combine(SrvRuntime.StartupPath, "wwwroot", "ServerCoreTools","systemTools", "newsletter-preview", "index.html"), data);
System.IO.File.WriteAllText(Path.Combine(_hostingEnvironment.WebRootPath, "ServerCoreTools", "systemTools", "newsletter-preview", "index.html"), data);


# Used Nugets
https://github.com/FubarDevelopment




# Build Project Command
https://github.com/dotnet/sdk/issues/9487
dotnet msbuild -property:Configuration=Release
dotnet build -c Debug  - in folder project.sln
msbuild /v:q  /t:Build /nologo /P:Configuration=Release MySolutionWithSevenProjectsInIt.sln

# Run Project
https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-run
dotnet run : command in project folder to run project
dotnet run --project ./projects/proj1/proj1.csproj --property:Configuration=Release


dotnet restore = update packages 
dotnet build
dotnet build --disable-build-servers
dotnet test
dotnet publish


# Search

https://github.com/LiveOrDevTrying/WebsocketsSimple WebSocketServer

https://github.com/igloo15/Nuget.Searcher     Nuget Server
https://github.com/igloo15/ChangelogGenerator/tree/master   Changelog Generator

https://github.com/FoxCouncil/FoxSsh/tree/main SSH server
https://github.com/KeenSystemsNL/SFTPServer  SFTP server

https://www.nuget.org/packages/ServiceStack.Server
dotnet add package ServiceStack.Server --version 10.0.4

https://github.com/dotnet/MQTTnet  Server
https://github.com/erikzaadi/GithubSharp
https://github.com/libgit2/libgit2sharp/

# Step 7 TIA Sharp7
https://github.com/fbarresi/Sharp7


# Search Nugets
https://nuget.info/packages
https://www.nuget.org/packages


# SignalR Video Stream
https://www.c-sharpcorner.com/article/screencastr-simple-screen-sharing-app-using-signalr-streaming/


# Repos
https://github.com/seesharper?tab=repositories  182repos
https://github.com/ggoodman?tab=repositories 174 JS Repos
https://github.com/orgs/google/repositories 2800 Js Repos
https://github.com/AArnott?tab=repositories 280 C# repos

# Solution
https://github.com/orgs/EasyMicroservices

### REMOVED PACKAGES
<PackageReference Include="AspNet.Security.OAuth.GitHub" Version="6.0.15" />
<PackageReference Include="AspNet.Security.OAuth.LinkedIn" Version="6.0.15" />
<PackageReference Include="AspNetCore.MailKitMailer" Version="1.2.2" />
    <PackageReference Include="AspNetCore.MailPost" Version="3.0.5.26" />
    <PackageReference Include="AspNetStatic" Version="0.24.0" />
    <PackageReference Include="Autofac" Version="8.1.0" />
    <PackageReference Include="Autofac.AspNetCore.Multitenant" Version="8.0.0" />
    <PackageReference Include="Autofac.Extras.AggregateService" Version="6.1.2" />
    <PackageReference Include="Autofac.Extras.AttributeMetadata" Version="6.0.0" />
    <PackageReference Include="Autofac.Extras.CommonServiceLocator" Version="6.1.0" />
    <PackageReference Include="Autofac.Mef" Version="7.0.0" />
    <PackageReference Include="Autofac.Multitenant" Version="8.0.3" />
    <PackageReference Include="BlendedJint" Version="3.0.0.1" />
    <PackageReference Include="Cake.XmlDocMarkdown" Version="2.9.0" />
    <PackageReference Include="Carter" Version="6.1.1" />
    <PackageReference Include="ChakraCore.NET" Version="1.3.3" />
    <PackageReference Include="ChakraCore.NET.Core" Version="1.1.3" />
    <PackageReference Include="ChakraCore.NET.Promise" Version="1.1.1" />
    <PackageReference Include="ConfigGen" Version="1.0.9" />
    <PackageReference Include="DatatableJS" Version="3.9.1" />
    <PackageReference Include="DatatableJS.Data" Version="3.8.0" />
    <PackageReference Include="DataTablePrettyPrinter" Version="0.2.0" />
    <PackageReference Include="DataTables.Queryable" Version="1.7.3" />
    <PackageReference Include="DelegateInterface" Version="1.4.0" />
    <PackageReference Include="Fluid.Core" Version="2.3.0" />
    <PackageReference Include="Fluid.ViewEngine" Version="2.3.0" />
    <PackageReference Include="FoxSsh" Version="0.1.0" />
    <PackageReference Include="FreeSpire.Barcode" Version="6.6.0" />
    <PackageReference Include="FreeSpire.Doc" Version="12.2.0" />
    <PackageReference Include="FreeSpire.Email" Version="6.5.2" />
    <PackageReference Include="FreeSpire.Office" Version="8.2.0" />
    <PackageReference Include="FreeSpire.PDF" Version="10.2.0" />
    <PackageReference Include="FreeSpire.Presentation" Version="7.8.0" />
    <PackageReference Include="FreeSpire.XLS" Version="14.2.0" />
    <PackageReference Include="GitVersioner" Version="17.12.29.2" />
    <PackageReference Include="GrobExp.Compiler" Version="1.3.23" />
    <PackageReference Include="GrobExp.Mutators" Version="1.4.16" />
    <PackageReference Include="HdrHistogram" Version="2.5.0" />
    <PackageReference Include="HT.Minify" Version="6.0.11" />
    <PackageReference Include="HTML.Generator.Helper" Version="1.0.0" />
    <PackageReference Include="HtmlGenerator" Version="2.0.0" />
    <PackageReference Include="HtmlSharpCore" Version="1.1.3" />
    <PackageReference Include="HtmlWarningsReportGenerator" Version="1.0.5" />
    <PackageReference Include="Jint" Version="4.0.0" />
    <PackageReference Include="Jint.CommonJS" Version="1.0.14" />
    <PackageReference Include="jose-jwt" Version="5.0.0" />
    <PackageReference Include="jsurl.TypeScript.DefinitelyTyped" Version="1.2.2.1" />
    <PackageReference Include="KubeClient" Version="2.5.10" />
    <PackageReference Include="linq2db" Version="5.4.1" />
    <PackageReference Include="linq2db.AspNet" Version="5.4.1" />
    <PackageReference Include="linq2db.EntityFrameworkCore" Version="6.17.0" />
    <PackageReference Include="linq2db.MySql" Version="5.4.1" />
    <PackageReference Include="linq2db.PostgreSQL" Version="5.4.1" />
    <PackageReference Include="linq2db.SQLite" Version="5.4.1" />
    <PackageReference Include="linq2db.SqlServer" Version="5.4.1" />
    <PackageReference Include="Magick.NET.Core" Version="13.6.0" />
    <PackageReference Include="MarkDownHtmlGenerator" Version="1.2.0" />
    <PackageReference Include="MarkdownToPdf.NET" Version="1.4.0" />
    <PackageReference Include="MarkdownWeb" Version="1.5.4" />
    <PackageReference Include="MarkdownWeb.AspNetCore" Version="1.0.8" />
    <PackageReference Include="MarkdownWeb.Git" Version="1.0.19" />
    <PackageReference Include="MarkdownWeb.Mvc5" Version="1.0.2" />
    <PackageReference Include="MarkedNet" Version="2.1.4" />
    <PackageReference Include="MassTransit.Hangfire" Version="8.2.2" />
    <PackageReference Include="MediaBrowser.Common" Version="4.8.2" />
    <PackageReference Include="MediaBrowser.Server.Core" Version="4.8.2" />
    <PackageReference Include="MermaidNetHtmlBuilder" Version="1.0.0" />
    <PackageReference Include="MiniProfiler.Shared" Version="4.3.8" />
    <PackageReference Include="MT.Blazor.ProtectedStorage" Version="0.0.0" />
    <PackageReference Include="NJsonSchema" Version="11.0.2" />
    <PackageReference Include="NJsonSchema.NewtonsoftJson" Version="11.0.2" />
    <PackageReference Include="NJsonSchema.Yaml" Version="11.0.2" />
    <PackageReference Include="NPOI" Version="2.6.2" />
    <PackageReference Include="OpenPop.Core" Version="1.0.0" />
     <PackageReference Include="Portable.Xaml" Version="0.26.0" />
    <PackageReference Include="PowerBridge" Version="1.3.6326.41344">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>
    <PackageReference Include="PowerScript.Bridge" Version="2.3.1" />
    <PackageReference Include="Processing.js" Version="1.3.6" />
     <PackageReference Include="Python.Deployment" Version="2.0.5" />
    <PackageReference Include="pythonnet" Version="3.0.3" />
     <PackageReference Include="RazorEngine.NetCore" Version="3.1.0" />
    <PackageReference Include="ReportGenerator" Version="5.2.4" />
    <PackageReference Include="ReportGenerator.Core" Version="5.1.10" />
    <PackageReference Include="RestSharp" Version="112.1.0" />
    <PackageReference Include="RotativaCore" Version="4.1.0" />
    <PackageReference Include="Scriban" Version="5.6.0" />
    <PackageReference Include="ScribanSourceGenerator" Version="1.1.0" />
    <PackageReference Include="SendGridSharp" Version="1.4.1" />
    <PackageReference Include="SendGridSharp.Core" Version="2.0.0" />
    <PackageReference Include="SerializationHelper" Version="2.0.0" />
    <PackageReference Include="ServiceAutoRegistration" Version="1.0.4" />
    <PackageReference Include="ServiceRegistration.NET" Version="1.0.0" />
    <PackageReference Include="SharpCompress" Version="0.36.0" />
    <PackageReference Include="SharpDocx" Version="2.5.0" />
    <PackageReference Include="SharpFluids" Version="3.0.497" />
    <PackageReference Include="SMBLibrary" Version="1.5.1.3" />
    <PackageReference Include="SMBLibrary.Adapters" Version="1.5.1" />
    <PackageReference Include="SMBLibrary.Async" Version="0.0.1" />
    <PackageReference Include="SMBLibrary.RootNS" Version="1.4.9" />
    <PackageReference Include="SMBLibraryCore.Client" Version="1.7.1" />
 <PackageReference Include="Sphinx" Version="1.0.0">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>
    <PackageReference Include="SphinxConnector" Version="5.4.0" />
    <PackageReference Include="Spire.Cloud.Sdk" Version="3.4.5" />
     <PackageReference Include="StackExchange.Redis.Extensions.Newtonsoft" Version="10.2.0" />
    <PackageReference Include="StackExchange.Redis.Extensions.Protobuf" Version="10.2.0" />
    <PackageReference Include="Streamx.Linq.SQL.EFCore" Version="6.0.1" />
    <PackageReference Include="TensorFlow.NET" Version="0.150.0" />
    <PackageReference Include="TensorFlowSharp" Version="1.15.1" />
    <PackageReference Include="Tesseract" Version="5.2.0" />
    <PackageReference Include="TimeZoneConverter" Version="6.1.0" />
    <PackageReference Include="Timingz" Version="2.0.1" />
    <PackageReference Include="TupleExtensions.VictorGavrish" Version="1.3.0" />
    <PackageReference Include="TweetinviAPI" Version="5.0.4" />
    <PackageReference Include="TweetinviAPI.AspNetPlugin" Version="5.0.4" />
    <PackageReference Include="TweetinviAPI.WebhooksPlugin" Version="4.0.0" />
    <PackageReference Include="Vereyon.Web.FlashMessage" Version="3.0.0" />
    <PackageReference Include="Vereyon.Web.HtmlSanitizer" Version="1.8.0" />
    <PackageReference Include="Verify.Playwright" Version="2.3.0" />
    <PackageReference Include="Watson" Version="6.1.1" />
    <PackageReference Include="Watson.Core" Version="6.1.1" />
    <PackageReference Include="WatsonTcp" Version="5.1.7" />
    <PackageReference Include="WatsonWebsocket" Version="4.1.2" />
     <PackageReference Include="WebOptimizer.JSObfuscator" Version="1.1.5" />
    <PackageReference Include="WebPush-NetCore" Version="1.0.2" />
    <PackageReference Include="WebStoating.Markdig.Prism" Version="1.0.0" />
     <PackageReference Include="Wexflow" Version="6.2.0" />
    <PackageReference Include="WM.HtmlToOpenXml" Version="1.0.1" />
     <PackageReference Include="XmlDocMarkdown" Version="2.9.0" />
    <PackageReference Include="XmlDocMarkdown.Core" Version="2.9.0" />
    <PackageReference Include="Yeoman" Version="1.1.2" />
    <PackageReference Include="Yeoman.PowerMvc" Version="0.4.0" />




