using HtmlAgilityPack;
using Markdig.Renderers.Docx;
using Markdig;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging.Abstractions;
using SharpCompress.Common;
using System.IO.Compression;
using Westwind.AspNetCore.Markdown;
using Pek.Markdig.HighlightJs;
using Markdown = Westwind.AspNetCore.Markdown.Markdown;
using OpenGraphNet;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Prometheus;
using System.Data.Entity.Core.Metadata.Edm;
using MongoDB.Bson.IO;
using DocumentFormat.OpenXml.Packaging;
using Eaf.Middleware.Authorization.Roles;
using CsvHelper.Configuration;

//TODO REFACTOR NEEDED  convert to simple more CALLS
namespace EasyITCenter.ServerCoreDBSettings {

    #region Generators Classes

   
    public class MDDocBookGeneratorRequest {
        public string WebRootFilePath { get; set; }
        public bool CentralIndexOnly { get; set; }
        public bool GenerateSummaryOnly { get; set; }
        public bool MdBookLibrary { get; set; }
        public bool LinkAllFileTypes { get; set; }
        public bool SetLinkedFileTypeOnly { get; set; }
        public string SetLinkFileExtension { get; set; }
        public bool ProcessRootPathOnly { get; set; }
        public bool OveriteExisting { get; set; }
        public bool CleanProcessed { get; set; }
    }


    #endregion

    /// <summary>
    ///  WebPages Knihovna API pro Nastroje 
    /// </summary>
    [Authorize]
    [ApiController]
    [Route("ServerApi")]
    //[ApiExplorerSettings(IgnoreApi = true)]
    public class ServerApiGeneratorDocsService : ControllerBase {


        /// <summary>
        /// Summary MDBook Generator Request
        /// Generate Central Index MD Book on Existing folder structure
        /// Generate Fulltext MDBook Library and clean Processed Structure
        /// Link All File Types, Images and Video Are Shown
        /// CentralIndexOnly = generate Docs with Link all All Files or by LinkedFileTypeOnly setting,
        /// MdBookLibrary = Generate FullSearch MdBookLibrary -HtmlFiles are converted to MD
        /// , For MD book are html files converted to MD
        /// ProcessRootPathOnly = only files in selected path will be processed,
        /// OverwriteExisting = Rewrite Output File if Exist,
        /// CleanProcessed = Delete the processed files,
        /// LinkedFileTypeOnly = Extension,
        /// SetLinkFileExtension = set the extension, for All or default do empty, other html,md,png
        /// example html if is set Linked File only, other md file will be used
        /// Mining INFO FROM: "html", "js", "css", "cs", "xaml", "sql","json", "bat", "sh", "cmd"
        /// </summary>
        [HttpPost("/ServerApi/GeneratorServices/MDDocBookGeneratorRequest")]
        [Consumes("application/json")]
        public async Task<IActionResult> MDDocBookGeneratorRequest([FromBody] MDDocBookGeneratorRequest webFilesRequest) {
            try {  WordprocessingDocument? document = null; var styles = new DocumentStyles(); DocxDocumentRenderer? renderer = null; MarkdownPipeline? pipeline = null;

                if (webFilesRequest.MdBookLibrary) {
                     document = DocxTemplateHelper.Standard;
                    renderer = new DocxDocumentRenderer(document, styles, NullLogger<DocxDocumentRenderer>.Instance);
                    pipeline = new MarkdownPipelineBuilder().UseEmphasisExtras().UseAbbreviations().UseAdvancedExtensions().UseBootstrap()
                    .UseDiagrams().UseEmphasisExtras().UseEmojiAndSmiley(true).UseDefinitionLists().UseTableOfContent().UseTaskLists()
                    .UseSmartyPants().UsePipeTables().UseMediaLinks().UseMathematics().UseListExtras().UseHighlightJs()
                    .UseGridTables().UseGlobalization().UseGenericAttributes().UseFootnotes().UseFooters().UseSyntaxHighlighting().UseFigures().Build();
                }

                string resultMessage = DbOperations.DBTranslate("ProcessSuccessfullyCompleted", ServerConfigSettings.ServiceServerLanguage);
                bool processInterrupted = false;
                List<string> indexRootList = new List<string>(); int docCounter = 0; bool mdBookPrepared = false;

                //Correction Paths
                webFilesRequest.WebRootFilePath = !webFilesRequest.WebRootFilePath.EndsWith("/") ? $"{webFilesRequest.WebRootFilePath}/" : webFilesRequest.WebRootFilePath;
                var folderList = System.IO.Directory.GetDirectories(ServerRuntimeData.WebRoot_path + FileOperations.ConvertSystemFilePathFromUrl(webFilesRequest.WebRootFilePath));
                folderList.ToList().ForEach(folder => indexRootList.Add(System.IO.Path.GetFullPath(folder).Split("\\").Last() + "\\"));

                string generatedFile = Environment.NewLine + (webFilesRequest.CentralIndexOnly ? $"# MD Docs Generated Index    " : $"# MD Docs Generated Library    ") + Environment.NewLine + Environment.NewLine + "[[toc]]" + Environment.NewLine + Environment.NewLine;
                indexRootList.ForEach(rootFolder => {

                    generatedFile += webFilesRequest.CentralIndexOnly ? $"### {rootFolder}    " + Environment.NewLine + Environment.NewLine
                    : $"    ```   {Environment.NewLine}{Environment.NewLine}  ---    {Environment.NewLine}";

                    List<string> fileList = FileOperations.GetPathFiles(ServerRuntimeData.WebRoot_path + FileOperations.ConvertSystemFilePathFromUrl(webFilesRequest.WebRootFilePath) + rootFolder,
                        $"*.{(webFilesRequest.LinkAllFileTypes ? "*" : string.IsNullOrWhiteSpace(webFilesRequest.SetLinkFileExtension) ? "md": webFilesRequest.SetLinkFileExtension)}"
                        , webFilesRequest.ProcessRootPathOnly ? SearchOption.TopDirectoryOnly : SearchOption.AllDirectories);

                    //PREPARE MD BOOK FOLDER FOR FILES
                    if (!mdBookPrepared && webFilesRequest.MdBookLibrary) {
                        mdBookPrepared = true;
                        FileOperations.DeleteDirectory(ServerRuntimeData.WebRoot_path + FileOperations.ConvertSystemFilePathFromUrl(webFilesRequest.WebRootFilePath) + "MdInteliBook");
                        FileOperations.CopyDirectory(Path.Combine(ServerRuntimeData.ServerGenerators_path, "Docs", "MdInteliBook"), ServerRuntimeData.WebRoot_path + FileOperations.ConvertSystemFilePathFromUrl(webFilesRequest.WebRootFilePath) + "MdInteliBook");
                    }

                    fileList.Where(a => !a.Contains(Path.Combine(Path.Combine(ServerRuntimeData.WebRoot_path) + FileOperations.ConvertSystemFilePathFromUrl(webFilesRequest.WebRootFilePath) + "MdInteliBook"))).ToList().ForEach(file => {
                        generatedFile += $"- [{Path.GetFileNameWithoutExtension(file)}](.{(webFilesRequest.CentralIndexOnly ? file.Split(Path.GetDirectoryName(webFilesRequest.WebRootFilePath)?.Split(Path.DirectorySeparatorChar).Last())[1] : "/" + Path.GetFileName(file))})   " + Environment.NewLine + Environment.NewLine;
                    });

                    //Generate File With Other File Types 
                    
                    fileList = FileOperations.GetPathFiles(ServerRuntimeData.WebRoot_path + FileOperations.ConvertSystemFilePathFromUrl(webFilesRequest.WebRootFilePath) + rootFolder, $"*." + (webFilesRequest.LinkAllFileTypes ? $"*" : webFilesRequest.SetLinkFileExtension), SearchOption.AllDirectories);
                    docCounter += 1; string newDoc = $"# List of Founded Other Files {rootFolder}" + Environment.NewLine + Environment.NewLine;
                    
                    string sourceCode = "";
                    fileList.Where(a => !Path.GetExtension(a.ToLower()).Contains(".md")).ToList().ForEach(file => {
                        string extension = Path.GetExtension(file).Substring(1).ToLower();
                        string solveFilename = Path.GetFileNameWithoutExtension(file).ToLower().Contains("index") ? "OriginalIndex" : Path.GetFileNameWithoutExtension(file);

                        if (!webFilesRequest.GenerateSummaryOnly) {
                            if (new string[] { "png", "jpg", "jpeg", "tiff", "bmp" }.Contains(extension)) {

                                //use only FIRST HOLDER running in RootPath
                                newDoc += $"   ![{solveFilename}](.{(webFilesRequest.CentralIndexOnly ? file.Split(Path.GetDirectoryName(webFilesRequest.WebRootFilePath)?.Split(Path.DirectorySeparatorChar).Last())[1].Replace(Path.GetFileNameWithoutExtension(file), solveFilename) : "/" + Path.GetFileName(file).Replace(Path.GetFileNameWithoutExtension(file), solveFilename))})   " + Environment.NewLine + Environment.NewLine;
                            }
                            else if (new string[] { "avi", "mpg", "mpeg", "mp3", "mp4" }.Contains(extension)) {
                                newDoc += $"   @[{solveFilename}](.{(webFilesRequest.CentralIndexOnly ? file.Split(Path.GetDirectoryName(webFilesRequest.WebRootFilePath)?.Split(Path.DirectorySeparatorChar).Last())[1].Replace(Path.GetFileNameWithoutExtension(file), solveFilename) : "/" + Path.GetFileName(file).Replace(Path.GetFileNameWithoutExtension(file), solveFilename))})   " + Environment.NewLine + Environment.NewLine;
                            }
                            else if (new string[] { "html", "js", "css", "cs", "xaml", "sql", "json", "bat", "sh", "cmd" }.Contains(extension)) {
                                string fileContent = System.IO.File.ReadAllText(file);
                                sourceCode += $"```{extension}{Environment.NewLine}{new ReverseMarkdown.Converter().Convert(fileContent)}{Environment.NewLine}```   " + Environment.NewLine + Environment.NewLine;

                                FileOperations.WriteToFile(ServerRuntimeData.WebRoot_path + FileOperations.ConvertSystemFilePathFromUrl(webFilesRequest.WebRootFilePath) + "MdInteliBook/src/" + Path.GetFileNameWithoutExtension(file) + ".md"
                                    , $"{fileContent}{Environment.NewLine} ");
                                newDoc += $"   [{Path.GetFileNameWithoutExtension(file)}](.{(webFilesRequest.CentralIndexOnly ? file.Split(Path.GetDirectoryName(webFilesRequest.WebRootFilePath)?.Split(Path.DirectorySeparatorChar).Last())[1].Replace(Path.GetFileNameWithoutExtension(file), solveFilename) + ".md" : "/" + Path.GetFileNameWithoutExtension(file) + ".md")})   " + Environment.NewLine + Environment.NewLine;
                            }
                        }
                    });
                    generatedFile += $"- [{docCounter}](./{docCounter}.md)   " + Environment.NewLine + sourceCode + Environment.NewLine;
                    FileOperations.WriteToFile(ServerRuntimeData.WebRoot_path + FileOperations.ConvertSystemFilePathFromUrl(webFilesRequest.WebRootFilePath) + $"{(webFilesRequest.MdBookLibrary ? "MdInteliBook/src/" : "")}{docCounter}.md", newDoc);
                    
                });
                //Save Index File
                FileOperations.WriteToFile((ServerRuntimeData.WebRoot_path + FileOperations.ConvertSystemFilePathFromUrl(webFilesRequest.WebRootFilePath) + $"{(webFilesRequest.MdBookLibrary ? "MdInteliBook/src/summary.md" : "index.md")}").Replace("/", "\\"), generatedFile);

                //COPY MD-BROWSER TOOL AFTER FILE PROCESSES
                if (!processInterrupted && webFilesRequest.CentralIndexOnly) {
                    FileOperations.CopyFiles(Path.Combine(ServerRuntimeData.ServerGenerators_path, "Docs", "MdBrowser"), ServerRuntimeData.WebRoot_path + FileOperations.ConvertSystemFilePathFromUrl(webFilesRequest.WebRootFilePath), webFilesRequest.OveriteExisting);
                }

                //SUMMARY MOVE FILES AND CLEAN STRUCTURE


                if (!processInterrupted && webFilesRequest.MdBookLibrary) {
                    indexRootList.ForEach(rootfolder => {
                        List<string> filelist = FileOperations.GetPathFiles(ServerRuntimeData.WebRoot_path + FileOperations.ConvertSystemFilePathFromUrl(webFilesRequest.WebRootFilePath) + rootfolder, "*.*", webFilesRequest.ProcessRootPathOnly ? SearchOption.TopDirectoryOnly : SearchOption.AllDirectories);
                        filelist.ForEach(file => {
                            FileOperations.CopyFile(file, ServerRuntimeData.WebRoot_path + FileOperations.ConvertSystemFilePathFromUrl(webFilesRequest.WebRootFilePath) + "MdInteliBook/src/" + Path.GetFileName(file));
                        });
                        if (webFilesRequest.CleanProcessed && rootfolder.Length > 2) { FileOperations.DeleteDirectory(rootfolder); }
                    });

                    //TODO RUN BOOK PROCESS     
                    RunProcessRequest process = new RunProcessRequest() {
                        Command = (ServerRuntimeData.WebRoot_path + FileOperations.ConvertSystemFilePathFromUrl(webFilesRequest.WebRootFilePath) + "MdInteliBook/" + "generate-mdbook.bat").Replace("/", "\\"),
                        WorkingDirectory = (ServerRuntimeData.WebRoot_path + FileOperations.ConvertSystemFilePathFromUrl(webFilesRequest.WebRootFilePath) + "MdInteliBook/").Replace("/", "\\")
                    };
                    string result = await CoreOperations.RunSystemProcess(process);
                }




                //ZipFile.CreateFromDirectory(Path.Combine(ServerRuntimeData.Startup_path, "Export", "Webpages"), Path.Combine(ServerRuntimeData.Startup_path, "Export", "Webpages.zip"));
                //var zipData = await System.IO.File.ReadAllBytesAsync(Path.Combine(ServerRuntimeData.Startup_path, "Export", "Webpages.zip"));
                //if (data != null) { return File(zipData, "application/x-zip-compressed", "Webpages.zip"); }
                //else { return BadRequest(new { message = DbOperations.DBTranslate("BadRequest", "en") }); }
                if (resultMessage == DbOperations.DBTranslate("ProcessSucessfullyCompleted", ServerConfigSettings.ServiceServerLanguage)) {
                    return new ContentResult() { Content = resultMessage, StatusCode = StatusCodes.Status200OK };
                }
                else { return new ContentResult() { Content = resultMessage, StatusCode = StatusCodes.Status200OK }; }
            } catch (Exception ex) { return new ContentResult() { Content = DataOperations.GetSystemErrMessage(ex), StatusCode = StatusCodes.Status200OK }; }
        }




        
    }
}