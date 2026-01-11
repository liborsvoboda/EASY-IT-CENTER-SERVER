

namespace EasyITCenter.Controllers {


    public class UploadPackageRequest {
        public string Filename { get; set; }
        public string Content { get; set; }

    }

    public class CreatePackageRequest {
        public string Filename { get; set; }
        public string Content { get; set; }

    }

    [Route("SystemApplicationService")]
    [ApiController]
    public class SystemApplicationService : ControllerBase {

/*
        [AllowAnonymous]
        [HttpPost("/SystemApplicationService/CreatePackage")]
        public async Task<IActionResult> CreatePackage([FromBody] CreatePackageRequest createPackageRequest) {
            try {

                if (HtttpContextExtension.IsAdmin() || HtttpContextExtension.IsWebAdmin()) {

                    FileOperations.DeleteDirectory(Path.Combine(SrvRuntime.TempPath, "tempPackage"));
                    FileOperations.DeleteDirectory(Path.Combine(SrvRuntime.TempPath, "extractPackage"));
                    FileOperations.ByteArrayToFile(Path.Combine(SrvRuntime.TempPath, "tempPackage", createPackageRequest.Filename), Convert.FromBase64String(createPackageRequest.Content.Split(",")[1]));

                    System.IO.Compression.ZipFile.ExtractToDirectory(Path.Combine(SrvRuntime.TempPath, "tempPackage", createPackageRequest.Filename), Path.Combine(SrvRuntime.TempPath, "extractPackage"));

                } else { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); }
            } catch (Exception ex) { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }



        [AllowAnonymous]
        [HttpPost("/SystemApplicationService/UploadPackage")]
        public async Task<string> UploadPackage([FromBody] List<UploadPackageRequest> uploadPackage) {
            try {
                FileOperations.DeleteDirectory(Path.Combine(SrvRuntime.TempPath, "tempPackage"));
                FileOperations.DeleteDirectory(Path.Combine(SrvRuntime.TempPath, "extractPackage"));
                FileOperations.ByteArrayToFile(Path.Combine(SrvRuntime.TempPath, "tempPackage", uploadPackage[0].Filename), Convert.FromBase64String(uploadPackage[0].Content.Split(",")[1]));

                System.IO.Compression.ZipFile.ExtractToDirectory(Path.Combine(SrvRuntime.TempPath, "tempPackage", uploadPackage[0].Filename), Path.Combine(SrvRuntime.TempPath, "extractPackage"));


            } catch (Exception ex) { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }

        */
    }
}