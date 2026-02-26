using DocumentFormat.OpenXml.Vml.Office;
using EasyITCenter.DBModel;
using FastReport.Utils;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Playwright;
using PuppeteerSharp;
using ScrapySharp.Network;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using Westwind.AspNetCore.Markdown;
using static EasyITCenter.Controllers.FileService;

namespace EasyITCenter.Controllers {


    [AllowAnonymous]
    [Route("/PublicStorageService")]
    public class PublicStorageService : Controller {

        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hostingEnvironment;
        public PublicStorageService(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment) {
            _hostingEnvironment = hostingEnvironment;
        }


        /// <summary>
        /// Get User Storage Structure
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("/PublicStorageService/GetPublicStorage")]
        [Consumes("application/json")]
        public async Task<IActionResult> GetPublicStorage() {
            FancyTreeUserData dir = new(); string path = null; string userRootPath = null;
            List<FancyTreeUserData> result = new();
            try {
                    userRootPath = path = SrvRuntime.SrvUserPublicPath;

                ScanDirectory:
                    result.AddRange(UserStorageOperations.GetUserDirectories(userRootPath + Path.DirectorySeparatorChar, path));
                    dir = result.Where(a => a.scanned == false).FirstOrDefault();

                    if (dir != null) {
                        path = Path.Combine(userRootPath, dir.path);
                        result.Remove(dir);
                        dir.scanned = true;
                        result.Add(dir);
                        result = result.OrderBy(a => a.title).ToList();
                        goto ScanDirectory;
                    }

                    //FILES Part
                    result.AddRange(UserStorageOperations.GetUserFiles(userRootPath + Path.DirectorySeparatorChar));

                result.OrderByDescending(a => a.path.Split(System.IO.Path.DirectorySeparatorChar).Length).ToList().ForEach(res => {
                    if (res.path.Split(System.IO.Path.DirectorySeparatorChar).Count() > 1) {
                        result.Where(a => a.path == string.Join(System.IO.Path.DirectorySeparatorChar, res.path.Split(System.IO.Path.DirectorySeparatorChar).Take(res.path.Split(System.IO.Path.DirectorySeparatorChar).Count() - 1))).First().children.Add(res);
                        result.Remove(res);
                    }
                });


                return base.Json(result);
            } catch (Exception ex) {
                return base.Json(result);
            }
        }


        /// <summary>
        /// Create User Storage Folder
        /// </summary>
        /// <param name="userStorageContent"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/PublicStorageService/CreatePublicFolder")]
        [Consumes("application/json")]
        public async Task<string> CreatePublicFolder([FromBody] UserStorageContent userStorageContent) {
            string userRootPath = null;
            try {
                if (HtttpContextExtension.IsWebAdmin() || HtttpContextExtension.IsAdmin()) {
                    userRootPath = SrvRuntime.SrvUserPublicPath;
                    userStorageContent.Path = userStorageContent.Path.StartsWith("/") ? userStorageContent.Path.Substring(1) : userStorageContent.Path.StartsWith("\\") ? userStorageContent.Path.Substring(1) : userStorageContent.Path;
                    FileOperations.CreateDirectory(Path.Combine(userRootPath, userStorageContent.Path));

                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                } else { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); }

                           
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        /// <summary>
        /// Rename User Storage Folder
        /// </summary>
        /// <param name="userStorageRenameDir"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/PublicStorageService/MovePublicFolder")]
        [Consumes("application/json")]
        public async Task<string> MovePublicFolder([FromBody] UserStorageRenameDir userStorageRenameDir) {
            string userRootPath = null;
            try {
                if (HtttpContextExtension.IsWebAdmin() || HtttpContextExtension.IsAdmin()) {
                    userRootPath = SrvRuntime.SrvUserPublicPath;
                    userStorageRenameDir.SourcePath = userStorageRenameDir.SourcePath.StartsWith("/") ? userStorageRenameDir.SourcePath.Substring(1) : userStorageRenameDir.SourcePath.StartsWith("\\") ? userStorageRenameDir.SourcePath.Substring(1) : userStorageRenameDir.SourcePath;
                    userStorageRenameDir.TargetPath = userStorageRenameDir.TargetPath.StartsWith("/") ? userStorageRenameDir.TargetPath.Substring(1) : userStorageRenameDir.TargetPath.StartsWith("\\") ? userStorageRenameDir.TargetPath.Substring(1) : userStorageRenameDir.TargetPath;

                    FileOperations.MoveDirectory(Path.Combine(userRootPath, userStorageRenameDir.SourcePath), Path.Combine(userRootPath, userStorageRenameDir.TargetPath));

                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                } else { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        /// <summary>
        /// Copy User Storage Folder
        /// </summary>
        /// <param name="userStorageRenameDir"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/PublicStorageService/CopyPublicFolder")]
        [Consumes("application/json")]
        public async Task<string> CopyPublicFolder([FromBody] UserStorageRenameDir userStorageRenameDir) {
            string userRootPath = null;
            try {
                if (HtttpContextExtension.IsWebAdmin() || HtttpContextExtension.IsAdmin()) {
                    userRootPath = SrvRuntime.SrvUserPublicPath;
                    userStorageRenameDir.SourcePath = userStorageRenameDir.SourcePath.StartsWith("/") ? userStorageRenameDir.SourcePath.Substring(1) : userStorageRenameDir.SourcePath.StartsWith("\\") ? userStorageRenameDir.SourcePath.Substring(1) : userStorageRenameDir.SourcePath;
                    userStorageRenameDir.TargetPath = userStorageRenameDir.TargetPath.StartsWith("/") ? userStorageRenameDir.TargetPath.Substring(1) : userStorageRenameDir.TargetPath.StartsWith("\\") ? userStorageRenameDir.TargetPath.Substring(1) : userStorageRenameDir.TargetPath;

                    FileOperations.CopyDirectory(Path.Combine(userRootPath, userStorageRenameDir.SourcePath), Path.Combine(userRootPath, userStorageRenameDir.TargetPath));

                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                } else { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        /// <summary>
        /// Download User Storage Folder
        /// </summary>
        /// <param name="userStorageContent"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/PublicStorageService/DownloadPublicFolder")]
        [Consumes("application/json")]
        public async Task<IActionResult> DownloadPublicFolder([FromBody] UserStorageContent userStorageContent) {
            string userRootPath = null;
            try {
                userStorageContent.Path = userStorageContent.Path.StartsWith("/") ? userStorageContent.Path.Substring(1) : userStorageContent.Path.StartsWith("\\") ? userStorageContent.Path.Substring(1) : userStorageContent.Path;
                if (HtttpContextExtension.IsLogged()) {
                    userRootPath = Path.Combine(SrvRuntime.SrvUserPublicPath, userStorageContent.Path);
                } else { return BadRequest(new { Status = DBResult.UnauthorizedRequest.ToString(), ErrorMessage = String.Empty }); }

                ZipFile.CreateFromDirectory(userRootPath, Path.Combine(SrvRuntime.SrvTempPath, FileOperations.GetLastFolderFromPath(userStorageContent.Path) + ".zip"));
                byte[] zipPackage = await System.IO.File.ReadAllBytesAsync(Path.Combine(SrvRuntime.SrvTempPath, FileOperations.GetLastFolderFromPath(userStorageContent.Path) + ".zip"));
                FileOperations.DeleteFile(Path.Combine(SrvRuntime.SrvTempPath, FileOperations.GetLastFolderFromPath(userStorageContent.Path) + ".zip"));

                return File(zipPackage, "application/x-zip-compressed", FileOperations.GetLastFolderFromPath(userStorageContent.Path) + ".zip");
            } catch (Exception ex) {
                return BadRequest(new { Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        /// <summary>
        /// Clear User Storage Folder
        /// </summary>
        /// <param name="userStorageContent"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/PublicStorageService/ClearPublicFolder")]
        [Consumes("application/json")]
        public async Task<string> ClearPublicFolder([FromBody] UserStorageContent userStorageContent) {
            string userRootPath = null;
            try {
                if (HtttpContextExtension.IsWebAdmin() || HtttpContextExtension.IsAdmin()) {
                    userStorageContent.Path = userStorageContent.Path.StartsWith("/") ? userStorageContent.Path.Substring(1) : userStorageContent.Path.StartsWith("\\") ? userStorageContent.Path.Substring(1) : userStorageContent.Path;
                    userRootPath = Path.Combine(SrvRuntime.SrvUserPublicPath, userStorageContent.Path);
                    FileOperations.ClearFolder(userRootPath);
                
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                } else { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        /// <summary>
        /// Delete User Storage Folder
        /// </summary>
        /// <param name="userStorageContent"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/PublicStorageService/DeletePublicFolder")]
        [Consumes("application/json")]
        public async Task<string> DeletePublicFolder([FromBody] UserStorageContent userStorageContent) {
            string userRootPath = null;
            try {
                if (HtttpContextExtension.IsWebAdmin() || HtttpContextExtension.IsAdmin()) {
                    userStorageContent.Path = userStorageContent.Path.StartsWith("/") ? userStorageContent.Path.Substring(1) : userStorageContent.Path.StartsWith("\\") ? userStorageContent.Path.Substring(1) : userStorageContent.Path;
                    userRootPath = Path.Combine(SrvRuntime.SrvUserPublicPath, userStorageContent.Path);
                    FileOperations.DeleteDirectory(userRootPath);

                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                } else { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        /// <summary>
        /// Create User Storage File
        /// </summary>
        /// <param name="userStorageContent"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/PublicStorageService/CreatePublicFile")]
        [Consumes("application/json")]
        public async Task<string> CreatePublicFile([FromBody] UserStorageContent userStorageContent) {
            string userRootPath = null;
            try {
                if (HtttpContextExtension.IsWebAdmin() || HtttpContextExtension.IsAdmin()) {
                    userStorageContent.Path = userStorageContent.Path.StartsWith("/") ? userStorageContent.Path.Substring(1) : userStorageContent.Path.StartsWith("\\") ? userStorageContent.Path.Substring(1) : userStorageContent.Path;
                    userRootPath = Path.Combine(SrvRuntime.SrvUserPath, userStorageContent.Path, userStorageContent.Filename);
                    FileOperations.CreateFile(userRootPath);

                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                } else { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        /// <summary>
        /// Save User Storage File
        /// </summary>
        /// <param name="userStorageContent"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/PublicStorageService/SetPublicTextFile")]
        [Consumes("application/json")]
        public async Task<string> SetPublicTextFile([FromBody] UserStorageContent userStorageContent) {
            string userRootPath = null; string result = null;

            try {
                if (HtttpContextExtension.IsWebAdmin() || HtttpContextExtension.IsAdmin()) {
                    userRootPath = SrvRuntime.SrvUserPublicPath;
                    userStorageContent.Path = userStorageContent.Path.StartsWith("/") ? userStorageContent.Path.Substring(1) : userStorageContent.Path.StartsWith("\\") ? userStorageContent.Path.Substring(1) : userStorageContent.Path;

                    FileOperations.WriteToFile(Path.Combine(userRootPath, userStorageContent.Path), userStorageContent.Content, true);

                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                } else { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        /// <summary>
        /// Rename User Storage File
        /// </summary>
        /// <param name="userStorageRenameDir"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/PublicStorageService/MovePublicFile")]
        [Consumes("application/json")]
        public async Task<string> MovePublicFile([FromBody] UserStorageRenameDir userStorageRenameDir) {
            string userRootPath = null;
            try {
                if (HtttpContextExtension.IsWebAdmin() || HtttpContextExtension.IsAdmin()) {
                    userRootPath = SrvRuntime.SrvUserPublicPath;

                    userStorageRenameDir.SourcePath = userStorageRenameDir.SourcePath.StartsWith("/") ? userStorageRenameDir.SourcePath.Substring(1) : userStorageRenameDir.SourcePath.StartsWith("\\") ? userStorageRenameDir.SourcePath.Substring(1) : userStorageRenameDir.SourcePath;
                    userStorageRenameDir.TargetPath = userStorageRenameDir.TargetPath.StartsWith("/") ? userStorageRenameDir.TargetPath.Substring(1) : userStorageRenameDir.TargetPath.StartsWith("\\") ? userStorageRenameDir.TargetPath.Substring(1) : userStorageRenameDir.TargetPath;

                    FileOperations.MoveFile(Path.Combine(userRootPath, userStorageRenameDir.SourcePath), Path.Combine(userRootPath, userStorageRenameDir.TargetPath));

                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                } else { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        /// <summary>
        /// Copy User Storage File
        /// </summary>
        /// <param name="userStorageRenameDir"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/PublicStorageService/CopyPublicFile")]
        [Consumes("application/json")]
        public async Task<string> CopyPublicFile([FromBody] UserStorageRenameDir userStorageRenameDir) {
            string userRootPath = null;
            try {
                if (HtttpContextExtension.IsWebAdmin() || HtttpContextExtension.IsAdmin()) {
                    userRootPath = SrvRuntime.SrvUserPublicPath;
                    userStorageRenameDir.SourcePath = userStorageRenameDir.SourcePath.StartsWith("/") ? userStorageRenameDir.SourcePath.Substring(1) : userStorageRenameDir.SourcePath.StartsWith("\\") ? userStorageRenameDir.SourcePath.Substring(1) : userStorageRenameDir.SourcePath;
                    userStorageRenameDir.TargetPath = userStorageRenameDir.TargetPath.StartsWith("/") ? userStorageRenameDir.TargetPath.Substring(1) : userStorageRenameDir.TargetPath.StartsWith("\\") ? userStorageRenameDir.TargetPath.Substring(1) : userStorageRenameDir.TargetPath;

                    FileOperations.CopyFile(Path.Combine(userRootPath, userStorageRenameDir.SourcePath), Path.Combine(userRootPath , userStorageRenameDir.TargetPath));

                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                } else { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        /// <summary>
        /// Delete User Storage Folder
        /// </summary>
        /// <param name="userStorageContent"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/PublicStorageService/DeletePublicFile")]
        [Consumes("application/json")]
        public async Task<string> DeletePublicFile([FromBody] UserStorageContent userStorageContent) {
            string userRootPath = null;
            try {
                if (HtttpContextExtension.IsWebAdmin() || HtttpContextExtension.IsAdmin()) {
                    userStorageContent.Path = userStorageContent.Path.StartsWith("/") ? userStorageContent.Path.Substring(1) : userStorageContent.Path.StartsWith("\\") ? userStorageContent.Path.Substring(1) : userStorageContent.Path;
                    
                    userRootPath = Path.Combine(SrvRuntime.SrvUserPublicPath, userStorageContent.Path);
                    FileOperations.DeleteFile(userRootPath);

                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                } else { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        /// <summary>
        /// Download User Storage File
        /// </summary>
        /// <param name="userStorageRenameDir"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/PublicStorageService/DownloadPublicFile")]
        [Consumes("application/json")]
        public async Task<IActionResult> DownloadPublicFile([FromBody] UserStorageContent userStorageContent) {
            string userRootPath = null; string tempFolder = null;
            try {
                userStorageContent.Path = userStorageContent.Path.StartsWith("/") ? userStorageContent.Path.Substring(1) : userStorageContent.Path.StartsWith("\\") ? userStorageContent.Path.Substring(1) : userStorageContent.Path;
                if (HtttpContextExtension.IsLogged()) {
                    userRootPath = Path.Combine(SrvRuntime.SrvUserPublicPath, userStorageContent.Path);
                } else {
                    return BadRequest(new { Status = DBResult.error.ToString(), ErrorMessage = String.Empty });
                }

                tempFolder = SrvRuntime.SrvTempPath + string.Join(System.IO.Path.DirectorySeparatorChar, userStorageContent.Path.Split(System.IO.Path.DirectorySeparatorChar).Take(userStorageContent.Path.Split(System.IO.Path.DirectorySeparatorChar).Count() - 1));
                FileOperations.DeleteDirectory(tempFolder); FileOperations.CreateDirectory(tempFolder);
                FileOperations.CopyFile(userRootPath, tempFolder + System.IO.Path.DirectorySeparatorChar + System.IO.Path.GetFileName(userStorageContent.Path));
                
                ZipFile.CreateFromDirectory(tempFolder, Path.Combine(SrvRuntime.SrvTempPath, System.IO.Path.GetFileNameWithoutExtension(userStorageContent.Path) + ".zip"));
                byte[] zipPackage = await System.IO.File.ReadAllBytesAsync(Path.Combine(SrvRuntime.SrvTempPath, System.IO.Path.GetFileNameWithoutExtension(userStorageContent.Path) + ".zip"));

                FileOperations.DeleteDirectory(tempFolder);
                FileOperations.DeleteFile(Path.Combine(SrvRuntime.SrvTempPath, System.IO.Path.GetFileNameWithoutExtension(userStorageContent.Path) + ".zip"));

                return File(zipPackage, "application/x-zip-compressed", System.IO.Path.GetFileNameWithoutExtension(userStorageContent.Path) + ".zip");
            } catch (Exception ex) {
                return BadRequest(new { Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        /// <summary>
        /// User Storage SUNEditor Galery List
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("/PublicStorageService/GetSunImageList")]
        [Consumes("application/json")]
        public async Task<IActionResult> GetSunImageList() {
            string userRootPath = null; List<string> extensionList = new();
            List<string> images = new(); List<UserStorageSunGallery> result = new();
            try {
                
                userRootPath = Path.Combine(SrvRuntime.SrvUserPublicPath, "Images");
                extensionList = DbOperations.GetServerParameterLists("ImageExtensionList").Value.Split(";").ToList();
                extensionList.ForEach(ext => {
                    images = FileOperations.GetPathFiles(userRootPath, $"*.{ext}", SearchOption.AllDirectories);
                    images.ForEach(img => { 
                        result.Add(new UserStorageSunGallery() {
                            name = System.IO.Path.GetFileName(img),
                            alt = System.IO.Path.GetFileNameWithoutExtension(img),
                            src = img.Replace(SrvRuntime.WebRootPath, "").Replace(System.IO.Path.DirectorySeparatorChar,'/'),
                            tag = FileOperations.GetLastFolderFromPath(img)
                        });
                    });
                });
                result = result.OrderBy(a => a.tag).ThenBy(a=>a.name).ToList();
                return base.Json(new JsonResultLower() { result = result, status = DBResult.success.ToString() }); ;
            } catch (Exception ex) {
                return base.Json(new WebClasses.JsonResult() { Result = DataOperations.GetUserApiErrMessage(ex), Status = DBResult.error.ToString() }); 
            }
        }


        /// <summary>
        /// Upload User Storage Files
        /// </summary>
        /// <param name="userStorageContent"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/PublicStorageService/UploadPublicFiles")]
        [Consumes("application/json")]
        public async Task<string> UploadPublicFiles([FromBody] UserStorageContent userStorageContent) {
            string userRootPath = null;
            try {
                if (HtttpContextExtension.IsWebAdmin() || HtttpContextExtension.IsAdmin()) {
                    userRootPath = SrvRuntime.SrvUserPublicPath;
                    userStorageContent.Path = userStorageContent.Path.StartsWith("/") ? userStorageContent.Path.Substring(1) : userStorageContent.Path.StartsWith("\\") ? userStorageContent.Path.Substring(1) : userStorageContent.Path;

                    userStorageContent.Files.ForEach(file => { FileOperations.ByteArrayToFile(Path.Combine(userRootPath, userStorageContent.Path , file.Filename), Convert.FromBase64String(file.Content.Split(",")[1]), true); });

                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = userStorageContent.Files.Count(), ErrorMessage = string.Empty });
                } else { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        /// <summary>
        /// User Download Html from URL
        /// </summary>
        /// <param name="downloadFileRequest"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/PublicStorageService/DownloadHtmlFromUrl")]
        [Consumes("application/json")]
        public async Task<string> DownloadHtmlFromUrl([FromBody] DownloadFileRequest downloadFileRequest) {
            
            try {
                if (HtttpContextExtension.IsWebAdmin() || HtttpContextExtension.IsAdmin()) {
                    var browserFetcher = new BrowserFetcher();
                    await browserFetcher.DownloadAsync();
                    await using var browser = await Puppeteer.LaunchAsync(new LaunchOptions { Headless = true });
                    await using var page = await browser.NewPageAsync();
                    await page.GoToAsync(downloadFileRequest.Url);

                    await page.EvaluateExpressionHandleAsync("document.fonts.ready");
                    string InnerHTML = await page.GetContentAsync();

                    FileOperations.WriteToFile(Path.Combine(SrvRuntime.SrvUserPublicPath, "Downloads", downloadFileRequest.Filename), InnerHTML, true);
                    
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                } else { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }



        /// <summary>
        /// User Download Md from Url
        /// </summary>
        /// <param name="downloadFileRequest"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/PublicStorageService/DownloadMdFromUrl")]
        [Consumes("application/json")]
        public async Task<string> DownloadMdFromUrl([FromBody] DownloadFileRequest downloadFileRequest) {

            try {
                if (HtttpContextExtension.IsWebAdmin() || HtttpContextExtension.IsAdmin()) {
                    string MdAsHtml = await Markdown.ParseFromUrlAsync(downloadFileRequest.Url, true, false, false);

                    FileOperations.WriteToFile(Path.Combine(SrvRuntime.SrvUserPublicPath, "Downloads", downloadFileRequest.Filename), MdAsHtml, true);

                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                } else { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        /// <summary>
        /// Generate PDF from URL
        /// </summary>
        /// <param name="downloadFileRequest"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/PublicStorageService/DownloadPdfFromUrl")]
        [Consumes("application/json")]
        public async Task<string> DownloadPdfFromUrl([FromBody] DownloadFileRequest downloadFileRequest) {

            try {
                if (HtttpContextExtension.IsWebAdmin() || HtttpContextExtension.IsAdmin()) {
                    var browserFetcher = new BrowserFetcher();
                    await browserFetcher.DownloadAsync();
                    await using var browser = await Puppeteer.LaunchAsync(new LaunchOptions { Headless = true });
                    await using var page = await browser.NewPageAsync();
                    await page.GoToAsync(downloadFileRequest.Url);

                    await page.EvaluateExpressionHandleAsync("document.fonts.ready");
                    await page.PdfAsync(Path.Combine(SrvRuntime.SrvUserPublicPath, "Downloads", downloadFileRequest.Filename));

                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                } else { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        /// <summary>
        /// Generate PNG Image from URL
        /// </summary>
        /// <param name="downloadFileRequest"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/PublicStorageService/DownloadImageFromUrl")]
        [Consumes("application/json")]
        public async Task<string> DownloadImageFromUrl([FromBody] DownloadFileRequest downloadFileRequest) {

            try {
                if (HtttpContextExtension.IsWebAdmin() || HtttpContextExtension.IsAdmin()) {
                    var browserFetcher = new BrowserFetcher();
                    await browserFetcher.DownloadAsync();
                    await using var browser = await Puppeteer.LaunchAsync(new LaunchOptions { Headless = true });
                    await using var page = await browser.NewPageAsync();
                    await page.GoToAsync(downloadFileRequest.Url);

                    await page.EvaluateExpressionHandleAsync("document.fonts.ready");
                    await page.ScreenshotAsync(Path.Combine(SrvRuntime.SrvUserPublicPath, "Downloads", downloadFileRequest.Filename));

                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                } else { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        /// <summary>
        /// Save converted MarkdownFile from Html
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/PublicStorageService/SaveMarkdownFile")]
        [Consumes("application/json")]
        public async Task<string> SaveMarkdownFile([FromBody] Files file) {
            try {
                if (HtttpContextExtension.IsWebAdmin() || HtttpContextExtension.IsAdmin()) {
                    FileOperations.WriteToFile(Path.Combine(SrvRuntime.SrvUserPublicPath, "Help", file.Filename + ".md"), file.Content, true);

                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = 1, ErrorMessage = string.Empty });
                } else { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        /// <summary>
        /// Unpack User Archive
        /// </summary>
        /// <param name="unpackArchiveRequest"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/PublicStorageService/UnpackArchive")]
        [Consumes("application/json")]
        public async Task<string> UnpackArchive([FromBody] UnpackArchiveRequest unpackArchiveRequest) {
            try {
                if (HtttpContextExtension.IsWebAdmin() || HtttpContextExtension.IsAdmin()) {
                    FileOperations.CreateDirectory(Path.Combine(SrvRuntime.SrvUserPublicPath, unpackArchiveRequest.TargetFolder));
                    System.IO.Compression.ZipFile.ExtractToDirectory(Path.Combine(SrvRuntime.SrvUserPublicPath, unpackArchiveRequest.FilePath), Path.Combine(SrvRuntime.SrvUserPublicPath, unpackArchiveRequest.TargetFolder));

                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = 1, ErrorMessage = string.Empty });
                } else { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        /// <summary>
        /// Save User Media File
        /// </summary>
        /// <param name="saveMediaFileRequest"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/PublicStorageService/SaveMediaFile")]
        [Consumes("application/json")]
        public async Task<string> SaveMediaFile([FromBody] SaveMediaFileRequest saveMediaFileRequest) {
            try {
                if ((HtttpContextExtension.IsWebAdmin() || HtttpContextExtension.IsAdmin()) && !string.IsNullOrWhiteSpace(saveMediaFileRequest.Content) ) {
                    FileOperations.ByteArrayToFile(Path.Combine(SrvRuntime.SrvUserPublicPath, saveMediaFileRequest.Path, saveMediaFileRequest.Filename + ( saveMediaFileRequest.Path == "Images" ? ".png" : saveMediaFileRequest.Path == "Audio" ? ".mp3" : ".mp4" )), Convert.FromBase64String(saveMediaFileRequest.Content.Split(",").Last()), true);

                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = 1, ErrorMessage = string.Empty });
                } else { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        /// <summary>
        /// Replace in Public Files
        /// </summary>
        /// <param name="replaceInFilesRequest"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/PublicStorageService/ReplaceInFiles")]
        [Consumes("application/json")]
        public async Task<IActionResult> ReplaceInFiles([FromBody] ReplaceInFilesRequest replaceInFilesRequest) {
            try {

                if (HtttpContextExtension.IsWebAdmin() || HtttpContextExtension.IsAdmin()) {
                    replaceInFilesRequest.WebRootPath = replaceInFilesRequest.WebRootPath.StartsWith("/") ? replaceInFilesRequest.WebRootPath.Substring(1) : replaceInFilesRequest.WebRootPath.StartsWith("\\") ? replaceInFilesRequest.WebRootPath.Substring(1) : replaceInFilesRequest.WebRootPath;
                    List<string>? sourceFiles = FileOperations.GetPathFiles(Path.Combine(SrvRuntime.SrvUserPublicPath, replaceInFilesRequest.WebRootPath), replaceInFilesRequest.FileMask, replaceInFilesRequest.RootDirectoryOnly ? SearchOption.TopDirectoryOnly : SearchOption.AllDirectories);
                    sourceFiles.ForEach(file => {
                        string fileContent = FileOperations.ReadTextFile(file);
                        fileContent = fileContent.Replace(replaceInFilesRequest.SourceContent, replaceInFilesRequest.TargetContent);
                        FileOperations.WriteToFile(file, fileContent, true);
                    });

                    return base.Ok(new WebClasses.JsonResult() { Result = sourceFiles.Count.ToString(), Status = DBResult.success.ToString() });
                } else {
                    return base.Ok(new WebClasses.JsonResult() { Result = String.Empty, Status = DBResult.UnauthorizedRequest.ToString() });
                }
            } catch (Exception ex) {
                return base.Ok(new WebClasses.JsonResult() { Result = DataOperations.GetErrMsg(ex), Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetErrMsg(ex) });
            }
        }
    }
}