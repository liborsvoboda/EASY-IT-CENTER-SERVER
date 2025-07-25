﻿using HtmlAgilityPack;
using System.IO.Compression;

namespace EasyITCenter.Controllers {

 
    [ApiController]
    [Route("ExportService")]
     //[ApiExplorerSettings(IgnoreApi = true)]
    public class ExportService : ControllerBase {
        private EasyITCenterContext Context { get; }

        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hostingEnvironment;
        public ExportService(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment, EasyITCenterContext context) {
            _hostingEnvironment = hostingEnvironment;
            Context = context;
        }

        //TODO MODIFY FOR ANY USER CAN HAVE CUSTOM PORTAL

        //[HttpGet("/ExportService/ExportWebPortal")]
        //public async Task<IActionResult> ExportWebPortal() {
        //    try {
        //        List<WebMenuList> data;
        //        using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) 
        //            { data = new EasyITCenterContext().WebMenuLists.ToList(); }

        //        FileOperations.CreatePath(Path.Combine(ServerRuntimeData.Startup_path, "Export", "Webpages"));
        //        FileOperations.ClearFolder(Path.Combine(ServerRuntimeData.Startup_path, "Export"));
        //        FileOperations.CopyDirectory(Path.Combine(ServerRuntimeData.Startup_path, ServerConfigSettings.DefaultStaticWebFilesFolder, "metro"), Path.Combine(ServerRuntimeData.Startup_path, "Export", "Webpages", "metro"));
        //        data.ForEach(menuItem => {
        //            try {
        //                HtmlWeb hw = new HtmlWeb();
        //                HtmlDocument doc = hw.Load((Request.IsHttps ? "https" : "http") + "://" + Request.Host + "/" + DataOperations.RemoveWhitespace(menuItem.Id + "-" + menuItem.Name));
        //                doc.Save(Path.Combine(ServerRuntimeData.Startup_path, "Export", "Webpages", DataOperations.RemoveWhitespace(menuItem.Id + "-" + menuItem.Name) + ".html"), Encoding.UTF8);
        //            } catch { }
        //        });

        //        ZipFile.CreateFromDirectory(Path.Combine(ServerRuntimeData.Startup_path, "Export", "Webpages"), Path.Combine(ServerRuntimeData.Startup_path, "Export", "Webpages.zip"));
        //        var zipData = await System.IO.File.ReadAllBytesAsync(Path.Combine(ServerRuntimeData.Startup_path, "Export", "Webpages.zip"));

        //        if (data != null) { return File(zipData, "application/x-zip-compressed", "Webpages.zip"); }
        //        else { return BadRequest(new { message = DbOperations.DBTranslate("BadRequest", "en") }); }
        //    } catch (Exception ex) { return BadRequest(new { message = DataOperations.GetSystemErrMessage(ex) }); }
        //}

        /// <summary>
        /// Update Translation Table By All Tables and Field Names For Export Offline Language
        /// Dictionary CZ for System
        /// </summary>
        /// <returns></returns>
        [HttpGet("/ExportService/XamlCz")]
        public async Task<IActionResult> ExportXamlCz() {
            try {
                new EasyITCenterContext().EasyITCenterCollectionFromSql<GenericDataList>("EXEC SpOperationFillTranslationTableList;");

                List<SystemTranslationList> data = null;
                using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) { data = new EasyITCenterContext().SystemTranslationLists.OrderBy(a => a.SystemName).ToList(); }

                string xmlExport = "<ResourceDictionary\r\n    xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"\r\n    xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\"\r\n    xmlns:system=\"clr-namespace:System;assembly=mscorlib\">";

                data.ForEach(translation => {
                if (!translation.SystemName.Any(Char.IsWhiteSpace)) { xmlExport += Environment.NewLine + "<system:String x:Key=\"" + DataOperations.FirstCharToLowerCase(translation.SystemName.Replace("&","")) + "\" xml:space=\"preserve\">" + (translation.DescriptionCz != null && translation.DescriptionCz.Length > 0 ? translation.DescriptionCz.Replace("&", "") : translation.SystemName.Replace("&", "")) + "</system:String>"; }
                });
                xmlExport += Environment.NewLine + "</ResourceDictionary>";

                return File(Encoding.UTF8.GetBytes(xmlExport), "application/xml", "StringResources.cs-CZ.xaml");
            } catch (Exception ex) { return BadRequest(new { message = DataOperations.GetErrMsg(ex) }); }
        }

        /// <summary>
        /// Update Translation Table By All Tables and Field Names For Export Offline Language
        /// Dictionary EN for System
        /// </summary>
        /// <returns></returns>
        [HttpGet("/ExportService/XamlEn")]
        public async Task<IActionResult> ExportXamlEn() {
            try {
                new EasyITCenterContext().EasyITCenterCollectionFromSql<GenericDataList>("EXEC SpOperationFillTranslationTableList;");

                List<SystemTranslationList> data = null;
                using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) { data = new EasyITCenterContext().SystemTranslationLists.OrderBy(a => a.SystemName).ToList(); }

                string xmlExport = "<ResourceDictionary\r\n    xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"\r\n    xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\"\r\n    xmlns:system=\"clr-namespace:System;assembly=mscorlib\">";

                data.ForEach(translation => {
                    if (!translation.SystemName.Any(Char.IsWhiteSpace)) { xmlExport += Environment.NewLine + "<system:String x:Key=\"" + DataOperations.FirstCharToLowerCase(translation.SystemName.Replace("&", "")) + "\" xml:space=\"preserve\">" + (translation.DescriptionEn != null && translation.DescriptionEn.Length > 0 ? translation.DescriptionEn.Replace("&", "") : translation.SystemName.Replace("&", "")) + "</system:String>"; }
                });
                xmlExport += Environment.NewLine + "</ResourceDictionary>";

                return File(Encoding.UTF8.GetBytes(xmlExport), "application/xml", "StringResources.xaml");
            } catch (Exception ex) { return BadRequest(new { message = DataOperations.GetErrMsg(ex) }); }
        }



        /// <summary>
        /// Minimal Export of Page for Running
        /// on every Web servers Without Needs anythink
        /// </summary>
        /// <returns></returns>
        [HttpGet("/ExportService/ExportStaticWebPortal")]
        public async Task<IActionResult> ExportStaticWebPortal() {
            try {

                FileOperations.CreatePath(Path.Combine(SrvRuntime.Startup_path, "Export"));
                FileOperations.ClearFolder(Path.Combine(SrvRuntime.Startup_path, "Export"));
                FileOperations.CreatePath(Path.Combine(SrvRuntime.Startup_path, "Export", "Webpages", "metro", "managed", "storage"));
                FileOperations.CopyDirectory(Path.Combine(SrvRuntime.Startup_path, DbOperations.GetServerParameterLists("DefaultStaticWebFilesFolder").Value, "metro", "managed", "storage"), Path.Combine(SrvRuntime.Startup_path, "Export", "Webpages", "metro", "managed", "storage"));

                string json = System.IO.File.ReadAllText(Path.Combine(SrvRuntime.Startup_path, "Export", "Webpages", "metro", "managed", "storage", "globalStorage.js"));
                FileOperations.WriteToFile(Path.Combine(SrvRuntime.Startup_path, "Export", "Webpages", "metro", "managed", "storage", "globalStorage.js"), json.Replace("window.location.origin", DbOperations.GetServerParameterLists("ServerPublicUrl").Value));

                HtmlWeb hw = new HtmlWeb();
                HtmlDocument doc = hw.Load((Request.IsHttps ? "https" : "http") + "://" + Request.Host + "/Portal");
                string index = doc.Text.Replace("../..", DbOperations.GetServerParameterLists("ServerPublicUrl").Value);
                System.IO.File.WriteAllText(Path.Combine(SrvRuntime.Startup_path, "Export", "Webpages", "Index.html"), index);

                ZipFile.CreateFromDirectory(Path.Combine(SrvRuntime.Startup_path, "Export", "Webpages"), Path.Combine(SrvRuntime.Startup_path, "Export", "Webpages.zip"));
                var zipData = await System.IO.File.ReadAllBytesAsync(Path.Combine(SrvRuntime.Startup_path, "Export", "Webpages.zip"));

                return File(zipData, "application/x-zip-compressed", "Webpages.zip");
            } catch (Exception ex) { return BadRequest(new { message = DataOperations.GetErrMsg(ex) }); }
        }


        /// <summary>
        /// Database Dgml Schema
        /// </summary>
        /// <returns></returns>
        [HttpGet("/ExportService/DgmlDatabaseSchema")]
        public IActionResult GetDgml() {
            if (bool.Parse(DbOperations.GetServerParameterLists("ModuleDbDiagramGeneratorEnabled").Value)) {
                var response = File(Encoding.UTF8.GetBytes(new EasyITCenterContext().AsDgml()), MimeTypes.GetMimeType("DBschema.dgml"), "DBschema.dgml");
                return response;
            }
            else { return null; }
        }


        /// <summary>
        /// Get Full DataBase SQL Script
        /// </summary>
        /// <returns></returns>
        [HttpGet("/ExportService/SqlDatabaseSchema")]
        public IActionResult Get() {
            if (bool.Parse(DbOperations.GetServerParameterLists("ModuleDbDiagramGeneratorEnabled").Value)) {
                var response = File(Encoding.UTF8.GetBytes(Context.AsSqlScript()), MimeTypes.GetMimeType("DBschema.sql"), "DBschema.sql");
                return response;
            }
            else { return null; }
        }
    }
}