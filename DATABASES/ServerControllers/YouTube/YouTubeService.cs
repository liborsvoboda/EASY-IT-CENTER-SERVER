
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using VideoLibrary;

namespace EasyITCenter.Controllers {

    /// <summary>
    /// Server Routing Rulles
    /// </summary>
    [Authorize]
    [Route("YoutubeService")]
    [ApiController]
    //[ApiExplorerSettings(IgnoreApi = true)]
    public class YoutubeService : ControllerBase {


        public class YoutubeRequest
        {
            public string Id { get; set; }
        }


        /// <summary>
        /// User Download Youtube Video/s
        /// </summary>
        /// <param name="youtubeRequest"></param>
        /// <returns></returns>
        [HttpPost("/YoutubeService/DownloadVideos")]
        public async Task<string> DownloadVideos([FromBody] YoutubeRequest youtubeRequest) {
            try {
                if (HttpContextExtension.IsLogged()) {
                    var service = Client.For(YouTube.Default);

                    var video = await service.GetVideoAsync($"https://youtube.com/watch?v={youtubeRequest.Id}");
                    var vid = await video.GetBytesAsync();
                    FileOperations.ByteArrayToFile(Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Videos", $"{video.Title}{video.FileExtension}"), vid, true);
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = string.Empty });

                } else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
            
        }



     
    }
}