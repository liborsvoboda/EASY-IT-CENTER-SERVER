using Microsoft.AspNetCore.Http;
using NUnit.Framework;
using SharpCompress.Common;
using System.Xml.Serialization;

namespace EasyITCenter.ControllersExtensions {

    /// <summary>
    /// https://stackoverflow.com/questions/78519634/uploading-images-using-editor-js
    /// </summary>
    public class UploadFileRequest {
        public string field { get; set; }
        public string types { get; set; }
        public string namePlaceholder { get; set; }
        public string descriptionPlaceholder { get; set; }
        public string linkPlaceholder { get; set; }
    }

    public class UploadFileResponse
    {
        public UploadFile file { get; set; }
        public int success { get; set; }
    }

    public class UploadFile {
        public string url { get; set; }
        public string name { get; set; }
        public long size { get; set; }
        public string type { get; set; }
    }


    /// <summary>
    /// Server Root Controller
    /// </summary>
    [ApiController]
     //[ApiExplorerSettings(IgnoreApi = true)]
    [Route("FileUploadService")]
    public class FileUploadService : Controller {


        /// <summary>
        ///  WebApi ContentTool SubmitRotator
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        [HttpGet("/FileUploadService/GetApiFileRotator/{filename}"), DisableRequestSizeLimit]
        public async Task<IActionResult> GetApiFileRotator(string filename) {
            try {
                byte[] fileArray = SrvRuntime.FileRotatorTool.FirstOrDefault(a => a.Key.ToString() == filename).Value as byte[];
                return File(fileArray, MimeTypes.GetMimeType(filename), filename);
            } catch (Exception ex) { return BadRequest(new string[] { "error:" + DataOperations.GetUserApiErrMessage(ex), "application/json" }); }
        }



        /// <summary>
        /// WebApi ConentTool WebBuilder File Responser
        /// </summary>
        /// <returns></returns>
        [HttpPost("/FileUploadService/PostApiFileRotator"), DisableRequestSizeLimit]
        public async Task<IActionResult> PostApiFileRotator(List<IFormFile> files) {
            string mimeType = null; byte[] loadedfile; string stringFile = null; byte[] fileByteArray = null;
            try {
                foreach (var formFile in Request.Form.Files) {
                    mimeType = MimeTypes.GetMimeType(formFile.FileName);
                    using (var ms = new MemoryStream()) {
                        formFile.CopyTo(ms);
                        fileByteArray = ms.ToArray();
                        stringFile = Convert.ToBase64String(fileByteArray);
                    }
                }

                string uniqueFilename = DataOperations.RandomString(20) + "." + mimeType.Split("/")[1];
                IDictionary<object, object> detail = new Dictionary<object, object> {
                    { "filename", uniqueFilename },
                    { "url", "/WebApi/GetApiFileRotator/" + uniqueFilename },
                    { "name", "image" },
                    { "size", stringFile.Length },
                    { "image", fileByteArray },
                    { "file",  File(fileByteArray, mimeType, DataOperations.RandomString(20) + "." + mimeType.Split("/")[1]) }
                };

                SrvRuntime.FileRotatorTool.Add(uniqueFilename, fileByteArray);
                return Ok(JsonSerializer.Serialize(detail));
            } catch (Exception ex) { return BadRequest(new string[] { "error:" + DataOperations.GetUserApiErrMessage(ex), "application/json" }); }
        }


        /// <summary>
        /// WebApi ConentTool WebBuilder File Responser
        /// </summary>
        /// <returns></returns>
        [HttpPost("/FileUploadService/PutApiFileRotator"), DisableRequestSizeLimit]
        public async Task<IActionResult> PutApiFileRotator(List<IFormFile> files) {
            string mimeType = null; byte[] loadedfile; string stringFile = null; byte[] fileByteArray = null;
            string filename = Request.Form.AsEnumerable().First(a => a.Key == "url").Value.ToString().Split("/").Last();
            try {

                byte[] fileArray = SrvRuntime.FileRotatorTool.FirstOrDefault(a => a.Key.ToString() == filename).Value as byte[];
                mimeType = MimeTypes.GetMimeType(filename);
                stringFile = Convert.ToBase64String(fileArray);
                IDictionary<object, object> detail = new Dictionary<object, object> {
                    { "filename", filename },
                    { "url", "/WebApi/GetApiFileRotator/" + filename },
                    { "name", "image" },
                    { "size", fileArray.Length },
                    { "image", fileArray },
                    { "file",  File(fileArray, mimeType, DataOperations.RandomString(20) + "." + mimeType.Split("/")[1]) }
                };

                SrvRuntime.FileRotatorTool.Remove(filename);
                return Ok(JsonSerializer.Serialize(detail));
            } catch (Exception ex) { return BadRequest(new string[] { "error:" + DataOperations.GetUserApiErrMessage(ex), "application/json" }); }
        }


        /// <summary>
        /// EditorJs File Upload
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [HttpPost("/FileUploadService/UploadEditorJSFile"), DisableRequestSizeLimit]
        public async Task<string> UploadEditorJSFile([FromForm] IFormFile file) {
            try
            {
                using (Stream fileStream = new FileStream(Path.Combine(SrvRuntime.ServerPortalPath, "addons", "editorjs", "files", file.FileName), FileMode.Create)) {
                    await file.CopyToAsync(fileStream);
                }

                return JsonSerializer.Serialize( new UploadFileResponse() {
                    success = 1, 
                    file = new UploadFile() { 
                        url = $"{DbOperations.GetServerParameterLists("ServerPublicUrl").Value}/server-portal/addons/editorjs/files/{file.FileName}",
                        type = file.ContentType, name = file.FileName, size = file.Length
                    }
                });
            } catch (Exception ex) { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }


        /// <summary>
        /// EditorJS Upload Image File
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        [HttpPost("/FileUploadService/UploadEditorJSImage"), DisableRequestSizeLimit]
        public async Task<string> UploadEditorJSImage([FromForm] IFormFile image) {
            try {

                using (Stream fileStream = new FileStream(Path.Combine(SrvRuntime.ServerPortalPath, "addons", "editorjs", "files", image.FileName), FileMode.Create)) {
                    await image.CopyToAsync(fileStream);
                }

                return JsonSerializer.Serialize(new UploadFileResponse() {
                    success = 1,
                    file = new UploadFile() {
                        url = $"{DbOperations.GetServerParameterLists("ServerPublicUrl").Value}/server-portal/addons/editorjs/files/{image.FileName}",
                        type = image.ContentType,
                        name = image.FileName,
                        size = image.Length
                    }
                });
            }
            catch (Exception ex) { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }
    }
}