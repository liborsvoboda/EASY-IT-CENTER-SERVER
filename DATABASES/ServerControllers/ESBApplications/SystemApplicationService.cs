

namespace EasyITCenter.Controllers {


    public class UploadPackageRequest {
        public string InheritedAppCategoryType { get; set; }
        public string InheritedAppType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MdContent { get; set; }
        public string AppPathName { get; set; }
        public string StartUpCommand { get; set; }
        public decimal ApplicationCredit { get; set; }
        public int UserId { get; set; }
        public List<UploadFile> Images { get; set; }
        public UploadFile Package { get; set; }

    }

    public class UploadFile
    {
        public string Filename { get; set; }
        public string Content { get; set; }
    }

    [Route("SystemApplicationService")]
    [ApiController]
    public class SystemApplicationService : ControllerBase {

        
        [AllowAnonymous]
        [HttpPost("/SystemApplicationService/UploadPackage")]
        public async Task<string> UploadPackage([FromBody] UploadPackageRequest uploadPackageRequest) {
            try {

                if (HtttpContextExtension.IsAdmin() || HtttpContextExtension.IsWebAdmin()) {

                    uploadPackageRequest.Images.ForEach(image => {
                        FileOperations.ByteArrayToFile(Path.Combine(SrvRuntime.SystemAppsPath, uploadPackageRequest.AppPathName, "Images", image.Filename), Convert.FromBase64String(image.Content.Split(",")[1]));
                    });
                    FileOperations.ByteArrayToFile(Path.Combine(SrvRuntime.SystemAppsPath, uploadPackageRequest.AppPathName, "Package", uploadPackageRequest.Package.Filename), Convert.FromBase64String(uploadPackageRequest.Package.Content.Split(",")[1]));

                    SystemApplicationList record = new() { 
                        Name = uploadPackageRequest.Name, InheritedAppCategoryType = uploadPackageRequest.InheritedAppCategoryType, InheritedAppType = uploadPackageRequest.InheritedAppType,
                        Description = uploadPackageRequest.Description, AppPathName = uploadPackageRequest.AppPathName, MdContent = uploadPackageRequest.MdContent,
                        StartUpCommand = uploadPackageRequest.StartUpCommand, ApplicationCredit = uploadPackageRequest.ApplicationCredit, UserId = uploadPackageRequest.UserId,
                    };
                    var data = new EasyITCenterContext().SystemApplicationLists.Add(record);
                    int result = await data.Context.SaveChangesAsync();
                    if (result > 0) return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                    else return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = result, ErrorMessage = string.Empty });

                    //System.IO.Compression.ZipFile.ExtractToDirectory(Path.Combine(SrvRuntime.TempPath, "tempPackage", createPackageRequest.Filename), Path.Combine(SrvRuntime.TempPath, "extractPackage"));
                } else { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); }
            } catch (Exception ex) { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }




    }
}