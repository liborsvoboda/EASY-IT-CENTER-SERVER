
namespace EasyITCenter.Controllers {

    [AllowAnonymous]
    [ApiController]
    [Route("SystemPortalApi/WebPages")]
     //[ApiExplorerSettings(IgnoreApi = true)]
    public class WebPagesSystemLoggerApi : ControllerBase {

        [HttpPost("/SystemPortalApi/SetWebSystemLogMessage")]
        public async Task<string> SetWebLogMessage([FromBody] WebSystemLogMessage record) {
            try {
                SolutionFailList solutionFailList = new SolutionFailList() {
                    InheritedLogMonitorType = "SystemPortal",
                    LogLevel = record.LogLevel,
                    Message = record.Message,
                    UserId = record.UserId,
                    UserName = record.UserName,
                    TimeStamp = DateTimeOffset.Now.DateTime,
                    AttachmentName = record.AttachmentName,
                    Attachment = record.Attachment,
                    ImageName = record.ImageName,
                    Image = record.Image
                };
                var data = new EasyITCenterContext().SolutionFailLists.Add(solutionFailList);
                int result = await data.Context.SaveChangesAsync();

                return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.success.ToString(), ErrorMessage = string.Empty });
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }
    }
}