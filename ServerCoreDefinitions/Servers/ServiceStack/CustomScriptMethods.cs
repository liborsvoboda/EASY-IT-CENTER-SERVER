using System.Threading.Tasks;
using ServiceStack;
using ServiceStack.Script;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System;
using ServiceStack.Redis;
using ServiceStack.OrmLite;
using System.Reflection;
using ServiceStack.IO;
using ServiceStack.Text;

namespace EasyITCenter.SharpScript
{

    /// <summary>
    /// State  ScriptMethods
    /// </summary>
    public class StateScriptMethods : ScriptMethods {
        bool HasAccess(Process process) {
            try { return process.TotalProcessorTime >= TimeSpan.Zero; } catch (Exception) { return false; }
        }

        public IEnumerable<Process> processes() => Process.GetProcesses().Where(HasAccess);
        public Process processById(int processId) => Process.GetProcessById(processId);
        public Process currentProcess() => Process.GetCurrentProcess();
        public DriveInfo[] drives() => DriveInfo.GetDrives();
    }

    /// <summary>
    /// GitHub ScriptMethods
    /// </summary>
    public class GitHubMarkdownScripts : ScriptMethods {
        public string ApiBaseUrl { get; set; } = "https://api.github.com";

        public bool UseMemoryCache { get; set; } = true;

        public string Mode { get; set; } = "gfm";

        public string RepositoryContext { get; set; }

        public IRawString markdown(ScriptScopeContext scope, string markdown) {
            var html = MarkdownConfig.Transformer.Transform(markdown);
            return html.ToRawString();
        }

        public static async Task<Stream> TransformToHtml(Stream markdownStream) {
            var md = await markdownStream.ReadToEndAsync();
            var html = MarkdownConfig.Transformer.Transform(md);
            return MemoryStreamFactory.GetStream(html.ToUtf8Bytes());
        }

        public static async Task<Stream> convertScriptToCodeBlocks(Stream renderedHtmlMarkdownBlock) {
            var html = await renderedHtmlMarkdownBlock.ReadToEndAsync();
            html = html.Replace("&lt;<span class=\"pl-ent\">script</span>&gt;",
                    "<span class=\"pl-en\">```code</span>")
                .Replace("&lt;/<span class=\"pl-ent\">script</span>&gt;",
                    "<span class=\"pl-en\">```</span>")
                .Replace("<span class=\"pl-s1\"><span class=\"pl-k\">&lt;</span><span class=\"pl-k\">/</span>script<span class=\"pl-k\">&gt;</span></span>",
                    "<span class=\"pl-en\">```</span>")
                .Replace("<span class=\"pl-s1\">&lt;/script&gt;</span>",
                    "<span class=\"pl-en\">```</span>");
            return MemoryStreamFactory.GetStream(html.ToUtf8Bytes());
        }

        public static async Task<Stream> convertScriptToLispBlocks(Stream renderedHtmlMarkdownBlock) {
            var html = await renderedHtmlMarkdownBlock.ReadToEndAsync();
            html = html.Replace("&lt;<span class=\"pl-ent\">script</span>&gt;",
                    "<span class=\"pl-en\">```lisp</span>")
                .Replace("&lt;/<span class=\"pl-ent\">script</span>&gt;",
                    "<span class=\"pl-en\">```</span>")
                .Replace("<span class=\"pl-s1\"><span class=\"pl-k\">&lt;</span><span class=\"pl-k\">/</span>script<span class=\"pl-k\">&gt;</span></span>",
                    "<span class=\"pl-en\">```</span>")
                .Replace("<span class=\"pl-s1\">&lt;/script&gt;</span>",
                    "<span class=\"pl-en\">```</span>");
            return MemoryStreamFactory.GetStream(html.ToUtf8Bytes());
        }

        static bool ReplaceUserContent = true;

        public async Task githubMarkdown(ScriptScopeContext scope, string markdownPath) {
            var file = Context.ProtectedMethods.ResolveFile(nameof(githubMarkdown), scope, markdownPath);
            var htmlFilePath = file.VirtualPath.LastLeftPart('.') + ".html";
            var cacheKey = nameof(GitHubMarkdownScripts) + ">" + htmlFilePath;

            var htmlFile = Context.VirtualFiles.GetFile(htmlFilePath);
            if (htmlFile != null && htmlFile.LastModified >= file.LastModified) {
                if (UseMemoryCache) {
                    byte[] bytes;
                    if (!Context.Cache.TryGetValue(cacheKey, out object oBytes)) {
                        using (var stream = htmlFile.OpenRead()) {
                            var ms = MemoryStreamFactory.GetStream();
                            using (ms) {
                                await stream.CopyToAsync(ms);
                                ms.Position = 0;
                                bytes = ms.ToArray();
                                Context.Cache[cacheKey] = bytes;
                            }
                        }
                    } else {
                        bytes = (byte[])oBytes;
                    }
                    scope.OutputStream.Write(bytes, 0, bytes.Length);
                } else {
                    using (var htmlReader = htmlFile.OpenRead()) {
                        await htmlReader.CopyToAsync(scope.OutputStream);
                    }
                }
            } else {
                var ms = MemoryStreamFactory.GetStream();
                using (ms) {
                    using (var stream = file.OpenRead()) {
                        await stream.CopyToAsync(ms);
                    }

                    ms.Position = 0;
                    var bytes = ms.ToArray();

                    var htmlBytes = RepositoryContext == null
                        ? await ApiBaseUrl.CombineWith("markdown", "raw")
                            .PostBytesToUrlAsync(bytes, contentType: "text/plain", requestFilter: x => x.With(c => c.UserAgent = "#Script"))
                        : await ApiBaseUrl.CombineWith("markdown")
                            .PostBytesToUrlAsync(new Dictionary<string, string> { { "text", bytes.FromUtf8Bytes() }, { "mode", Mode }, { "context", RepositoryContext } }.ToJson().ToUtf8Bytes(),
                                contentType: "application/json", requestFilter: x => x.With(c => c.UserAgent = "#Script"));

                    byte[] wrappedBytes = null;

                    if (ReplaceUserContent) {
                        var html = htmlBytes.FromUtf8Bytes();
                        html = html.Replace("user-content-", "");
                        wrappedBytes = ( "<div class=\"gfm\">" + html + "</div>" ).ToUtf8Bytes();
                    } else {
                        var headerBytes = "<div class=\"gfm\">".ToUtf8Bytes();
                        var footerBytes = "</div>".ToUtf8Bytes();

                        wrappedBytes = new byte[headerBytes.Length + htmlBytes.Length + footerBytes.Length];
                        System.Buffer.BlockCopy(headerBytes, 0, wrappedBytes, 0, headerBytes.Length);
                        System.Buffer.BlockCopy(htmlBytes, 0, wrappedBytes, headerBytes.Length, htmlBytes.Length);
                        System.Buffer.BlockCopy(footerBytes, 0, wrappedBytes, headerBytes.Length + htmlBytes.Length, footerBytes.Length);
                    }

                    if (Context.VirtualFiles is IVirtualFiles vfs) {
                        var fs = vfs.GetFileSystemVirtualFiles();
                        fs.DeleteFile(htmlFilePath);
                        fs.WriteFile(htmlFilePath, wrappedBytes);
                    }

                    if (UseMemoryCache) {
                        Context.Cache[cacheKey] = wrappedBytes;
                    }
                    await scope.OutputStream.WriteAsync(wrappedBytes, 0, wrappedBytes.Length);
                }
            }
        }
    }


    /// <summary>
    /// Custom ScriptMethods
    /// </summary>
    public class CustomScriptMethods : ScriptMethods
    {
        public Dictionary<int, KeyValuePair<string, string>> DocsIndex { get; } = new Dictionary<int, KeyValuePair<string, string>>();
        public Dictionary<int, KeyValuePair<string, string>> AppsIndex { get; } = new Dictionary<int, KeyValuePair<string, string>>();
        public Dictionary<int, KeyValuePair<string, string>> CodeIndex { get; } = new Dictionary<int, KeyValuePair<string, string>>();
        public Dictionary<int, KeyValuePair<string, string>> LispIndex { get; } = new Dictionary<int, KeyValuePair<string, string>>();
        public Dictionary<int, KeyValuePair<string, string>> UseCasesIndex { get; } = new Dictionary<int, KeyValuePair<string, string>>();
        public Dictionary<int, KeyValuePair<string, string>> LinqIndex { get; } = new Dictionary<int, KeyValuePair<string, string>>();

        public object prevDocLink(int order)
        {
            if (DocsIndex.TryGetValue(order - 1, out KeyValuePair<string,string> entry))
                return entry;
            return null;
        }

        public object nextDocLink(int order)
        {
            if (DocsIndex.TryGetValue(order + 1, out KeyValuePair<string,string> entry))
                return entry;
            return null;
        }

        public object prevAppsLink(int order)
        {
            if (AppsIndex.TryGetValue(order - 1, out KeyValuePair<string,string> entry))
                return entry;
            return null;
        }

        public object nextAppsLink(int order)
        {
            if (AppsIndex.TryGetValue(order + 1, out KeyValuePair<string,string> entry))
                return entry;
            return null;
        }

        public object prevCodeLink(int order)
        {
            if (CodeIndex.TryGetValue(order - 1, out KeyValuePair<string,string> entry))
                return entry;
            return null;
        }

        public object nextCodeLink(int order)
        {
            if (CodeIndex.TryGetValue(order + 1, out KeyValuePair<string,string> entry))
                return entry;
            return null;
        }

        public object prevLispLink(int order)
        {
            if (LispIndex.TryGetValue(order - 1, out KeyValuePair<string,string> entry))
                return entry;
            return null;
        }

        public object nextLispLink(int order)
        {
            if (LispIndex.TryGetValue(order + 1, out KeyValuePair<string,string> entry))
                return entry;
            return null;
        }

        public object prevUseCaseLink(int order)
        {
            if (UseCasesIndex.TryGetValue(order - 1, out KeyValuePair<string,string> entry))
                return entry;
            return null;
        }

        public object nextUseCaseLink(int order)
        {
            if (UseCasesIndex.TryGetValue(order + 1, out KeyValuePair<string,string> entry))
                return entry;
            return null;
        }

        public object prevLinqLink(int order)
        {
            if (LinqIndex.TryGetValue(order - 1, out KeyValuePair<string,string> entry))
                return entry;
            return null;
        }

        public object nextLinqLink(int order)
        {
            if (LinqIndex.TryGetValue(order + 1, out KeyValuePair<string,string> entry))
                return entry;
            return null;
        }

        List<KeyValuePair<string,string>> sortedDocLinks;
        public object docLinks() => sortedDocLinks ?? (sortedDocLinks = sortLinks(DocsIndex));

        List<KeyValuePair<string,string>> sortedAppsLinks;
        public object appsLinks() => sortedAppsLinks ?? (sortedAppsLinks = sortLinks(AppsIndex));

        List<KeyValuePair<string,string>> sortedCodeLinks;
        public object codeLinks() => sortedCodeLinks ?? (sortedCodeLinks = sortLinks(CodeIndex));
        List<KeyValuePair<string,string>> sortedLispLinks;
        public object lispLinks() => sortedLispLinks ?? (sortedLispLinks = sortLinks(LispIndex));

        List<KeyValuePair<string,string>> sortedUseCaseLinks;
        public object useCaseLinks() => sortedUseCaseLinks ?? (sortedUseCaseLinks = sortLinks(UseCasesIndex));

        List<KeyValuePair<string,string>> sortedLinqLinks;
        public object linqLinks() => sortedLinqLinks ?? (sortedLinqLinks = sortLinks(LinqIndex));

        public List<KeyValuePair<string,string>> sortLinks(Dictionary<int, KeyValuePair<string,string>> links)
        {
            var sortedKeys = links.Keys.ToList();
            sortedKeys.Sort();

            var to = new List<KeyValuePair<string,string>>();

            foreach (var key in sortedKeys)
            {
                var entry = links[key];
                to.Add(entry);
            }

            return to;
        }

        public async Task includeContentFile(ScriptScopeContext scope, string virtualPath)
        {
            var file = HostContext.VirtualFiles.GetFile(virtualPath);
            if (file == null)
                throw new FileNotFoundException($"includeContentFile '{virtualPath}' was not found");

            using (var reader = file.OpenRead())
            {
                await reader.CopyToAsync(scope.OutputStream);
            }
        }

        public List<Customer> customers() => TemplateQueryData.Customers;

        public Process[] processes => Process.GetProcesses();
        public Process[] processesByName(string name) => Process.GetProcessesByName(name);
        public Process processById(int processId) => Process.GetProcessById(processId);
        public Process currentProcess() => Process.GetCurrentProcess();

        Type GetFilterType(string name) => name switch {
            nameof(DefaultScripts) =>      typeof(DefaultScripts),
            nameof(HtmlScripts) =>         typeof(HtmlScripts),
            nameof(ProtectedScripts) =>    typeof(ProtectedScripts),
            nameof(InfoScripts) =>         typeof(InfoScripts),
            nameof(RedisScripts) =>        typeof(RedisScripts),
            nameof(DbScriptsAsync) =>      typeof(DbScriptsAsync),
            nameof(ValidateScripts) =>     typeof(ValidateScripts),
            nameof(AutoQueryScripts) =>    typeof(AutoQueryScripts),
            nameof(ServiceStackScripts) => typeof(ServiceStackScripts),
            _ => throw new NotSupportedException(name)
        };

        public IRawString methodLinkToSrc(string name)
        {
            const string prefix = "https://github.com/ServiceStack/ServiceStack/blob/master/src/ServiceStack.Common/Script/Methods/";

            var type = GetFilterType(name);
            var url = type == typeof(DefaultScripts)
                ? prefix
                : type == typeof(HtmlScripts) || type == typeof(ProtectedScripts)
                    ? $"{prefix}{type.Name}.cs"
                    : type == typeof(InfoScripts)
                    ? "https://github.com/ServiceStack/ServiceStack/blob/master/src/ServiceStack/InfoScripts.cs"
                    : type == typeof(RedisScripts)
                    ? "https://github.com/ServiceStack/ServiceStack.Redis/blob/master/src/ServiceStack.Redis/RedisScripts.cs"
                    : type == typeof(DbScriptsAsync)
                    ? "https://github.com/ServiceStack/ServiceStack.OrmLite/tree/master/src/ServiceStack.OrmLite/DbScriptsAsync.cs"
                    : type == typeof(ValidateScripts)
                    ? "https://github.com/ServiceStack/ServiceStack/blob/master/src/ServiceStack/ValidateScripts.cs"
                    : type == typeof(AutoQueryScripts)
                    ? "https://github.com/ServiceStack/ServiceStack/blob/master/src/ServiceStack.Server/AutoQueryScripts.cs"
                    : type == typeof(ServiceStackScripts)
                    ? "https://github.com/ServiceStack/ServiceStack/blob/master/src/ServiceStack/ServiceStackScripts.cs"
                    : prefix;

            return new RawString($"<a href='{url}'>{type.Name}.cs</a>");
        }

        public ScriptMethodInfo[] methodsAvailable(string name) => ScriptMethodInfo.GetMethodsAvailable(GetFilterType(name));
    }







}
