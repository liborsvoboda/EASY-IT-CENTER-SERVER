

using System.IO.Compression;

namespace EasyITCenter.Controllers {


    [AllowAnonymous]
    [Route("DashboardService")]
    [ApiController]
    public class DashboardService : Controller
    {

        
        /// <summary>
        /// Get Dashboard Counters
        /// </summary>
        /// <returns></returns>
        [HttpGet("/DashboardService/GetToolsCounter")]
        public async Task<IActionResult> GetToolsCounter() {
            List<Tuple<string, int>> result = new List<Tuple<string, int>>();
            try {

                string[] data = Directory.GetDirectories(Path.Combine(SrvRuntime.SrvLibraryPath, "Templates", "MetroExamples", "examples"));
                result.Add(new Tuple<string, int>("MoreExamples", data.Length));

                data = Directory.GetDirectories(Path.Combine(SrvRuntime.SrvLibraryPath, "Templates", "MetroWeb"));
                result.Add(new Tuple<string, int>("MetroWeb", data.Length));

                result.Add(new Tuple<string, int>("Metro", 8));

                data = Directory.GetDirectories(Path.Combine(SrvRuntime.SrvLibraryPath, "Modules", "javascript"));
                result.Add(new Tuple<string, int>("ModulesJs", data.Length));

                data = Directory.GetDirectories(Path.Combine(SrvRuntime.SrvLibraryPath, "Awesome"));
                result.Add(new Tuple<string, int>("Awesome", data.Length));


                return base.Json(result);
            } catch (Exception ex) {
                return base.Json(result);
            }
        }



        /// <summary>
        /// Get File Storage From Library
        /// </summary>
        /// <returns></returns>
        [HttpGet("/DashboardService/GetLibraryStorage")]
        public async Task<IActionResult> GetLibraryStorage([FromQuery] string loadpath) {
            FancyTreeUserData dir = new(); string path = null; string userRootPath = null; 
            List<FancyTreeUserData> result = new();
            try {
                loadpath = loadpath.StartsWith("/") ? loadpath.Substring(1) : loadpath.StartsWith("\\") ? loadpath.Substring(1) : loadpath;
                userRootPath = path = Path.Combine(SrvRuntime.SrvLibraryPath, loadpath);

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



        [AllowAnonymous]
        [HttpPost("/DashboardService/SearchInFiles")]
        [Consumes("application/json")]
        public async Task<IActionResult> SearchInFiles([FromBody] SearchInFilesRequest searchInFilesRequest)
        {
            FancyTreeUserData dir = new(); string path = null; string userRootPath = null;
            List<FancyTreeUserData> result = new();
            try
            {
                if (HttpContextExtension.IsLogged())
                {
                    searchInFilesRequest.DataPath = searchInFilesRequest.DataPath.StartsWith("/") ? searchInFilesRequest.DataPath.Substring(1) : searchInFilesRequest.DataPath.StartsWith("\\") ? searchInFilesRequest.DataPath.Substring(1) : searchInFilesRequest.DataPath;
                    userRootPath = path = Path.Combine(SrvRuntime.SrvLibraryPath, searchInFilesRequest.DataPath);

                ScanDirectory:
                    result.AddRange(UserStorageOperations.GetUserDirectories(userRootPath + Path.DirectorySeparatorChar, path));
                    dir = result.Where(a => a.scanned == false).FirstOrDefault();

                    if (dir != null)
                    {
                        path = Path.Combine(userRootPath, dir.path);
                        result.Remove(dir);
                        dir.scanned = true;
                        result.Add(dir);
                        result = result.OrderBy(a => a.title).ToList();
                        goto ScanDirectory;
                    }
                }
                else { return base.Json(result); }

                //FILES Part
                result.AddRange(UserStorageOperations.SearchUserFiles(userRootPath + Path.DirectorySeparatorChar, searchInFilesRequest.SearchInput));

                result.OrderByDescending(a => a.path.Split(System.IO.Path.DirectorySeparatorChar).Length).ToList().ForEach(res => {
                    if (res.path.Split(System.IO.Path.DirectorySeparatorChar).Count() > 1)
                    {
                        result.Where(a => a.path == string.Join(System.IO.Path.DirectorySeparatorChar, res.path.Split(System.IO.Path.DirectorySeparatorChar).Take(res.path.Split(System.IO.Path.DirectorySeparatorChar).Count() - 1))).First().children.Add(res);
                        result.Remove(res);
                    }
                });
                return base.Json(result);
            }
            catch (Exception ex)
            {
                return base.Json(result);
            }
        }


        [AllowAnonymous]
        [HttpPost("/DashboardService/DownloadLibraryFolder")]
        [Consumes("application/json")]
        public async Task<IActionResult> DownloadLibraryFolder([FromBody] UserStorageContent userStorageContent) {
            string userRootPath = null;
            try {
                userStorageContent.Path = userStorageContent.Path.StartsWith("/") ? userStorageContent.Path.Substring(1) : userStorageContent.Path.StartsWith("\\") ? userStorageContent.Path.Substring(1) : userStorageContent.Path;
                userRootPath = Path.Combine(SrvRuntime.SrvLibraryPath, userStorageContent.Path);

                FileOperations.ClearFolder(SrvRuntime.SrvTempPath);
                ZipFile.CreateFromDirectory(userRootPath, Path.Combine(SrvRuntime.SrvTempPath, FileOperations.GetLastFolderFromPath(userStorageContent.Path) + ".zip"));
                byte[] zipPackage = await System.IO.File.ReadAllBytesAsync(Path.Combine(SrvRuntime.SrvTempPath, FileOperations.GetLastFolderFromPath(userStorageContent.Path) + ".zip"));
                FileOperations.DeleteFile(Path.Combine(SrvRuntime.SrvTempPath, FileOperations.GetLastFolderFromPath(userStorageContent.Path) + ".zip"));

                return File(zipPackage, "application/x-zip-compressed", FileOperations.GetLastFolderFromPath(userStorageContent.Path) + ".zip");
            } catch (Exception ex) {
                return BadRequest(new { Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        [AllowAnonymous]
        [HttpPost("/DashboardService/DownloadLibraryFile")]
        [Consumes("application/json")]
        public async Task<IActionResult> DownloadLibraryFile([FromBody] UserStorageContent userStorageContent)
        {
            string userRootPath = null; string tempFolder = null;
            try
            {
                userStorageContent.Path = userStorageContent.Path.StartsWith("/") ? userStorageContent.Path.Substring(1) : userStorageContent.Path.StartsWith("\\") ? userStorageContent.Path.Substring(1) : userStorageContent.Path;
                userRootPath = Path.Combine(SrvRuntime.SrvLibraryPath, userStorageContent.Path);

                tempFolder = Path.Combine(SrvRuntime.SrvTempPath) + string.Join(System.IO.Path.DirectorySeparatorChar, userStorageContent.Path.Split(System.IO.Path.DirectorySeparatorChar).Take(userStorageContent.Path.Split(System.IO.Path.DirectorySeparatorChar).Count() - 1));
                FileOperations.DeleteDirectory(tempFolder); FileOperations.CreateDirectory(tempFolder);
                FileOperations.CopyFile(userRootPath, tempFolder + System.IO.Path.DirectorySeparatorChar + System.IO.Path.GetFileName(userStorageContent.Path));

                ZipFile.CreateFromDirectory(tempFolder, Path.Combine(SrvRuntime.SrvTempPath, System.IO.Path.GetFileNameWithoutExtension(userStorageContent.Path) + ".zip"));
                byte[] zipPackage = await System.IO.File.ReadAllBytesAsync(Path.Combine(SrvRuntime.SrvTempPath, System.IO.Path.GetFileNameWithoutExtension(userStorageContent.Path) + ".zip"));

                FileOperations.DeleteDirectory(tempFolder);
                FileOperations.DeleteFile(Path.Combine(SrvRuntime.SrvTempPath, System.IO.Path.GetFileNameWithoutExtension(userStorageContent.Path) + ".zip"));

                return File(zipPackage, "application/x-zip-compressed", System.IO.Path.GetFileNameWithoutExtension(userStorageContent.Path) + ".zip");
            }
            catch (Exception ex)
            {
                return BadRequest(new { Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }
    }
}