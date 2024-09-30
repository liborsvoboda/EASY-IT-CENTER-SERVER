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
using CsvHelper.Configuration;
using MassTransit.SagaStateMachine;
using PuppeteerExtraSharp.Plugins.ExtraStealth.Evasions;

//TODO REFACTOR NEEDED  convert to simple more CALLS
namespace EasyITCenter.ServerCoreDBSettings {



    [ApiController]
    [Route("AdminApi")]
    [Authorize(Roles = "admin")]
    public class AdminApiManagementService : ControllerBase {

        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hostingEnvironment;

        /// <summary>
        /// IS FOR WORKING WITH WWWDATA OF PROJECT FOLDER
        /// If Used in Code Path file storage modify Project wwwroot 
        /// not need Transfer changed data from BIN/DEGUG to Project
        /// Usage: _hostingEnvironment.WebRootPath
        /// </summary>
        /// <param name="hostingEnvironment"></param>
        public AdminApiManagementService(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment) {
            _hostingEnvironment = hostingEnvironment; 
        }


    

        
    }
}