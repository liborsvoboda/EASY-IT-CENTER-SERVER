namespace EasyITCenter.ServerCoreDBSettings {

    /// <summary>
    /// Server Email sender Api for logged Communication
    /// </summary>
    /// <seealso cref="ControllerBase"/>
    [Authorize]
    [ApiController]
    [Route("ServerApi")]
     //[ApiExplorerSettings(IgnoreApi = true)]
    public class ServerApiEmailService : ControllerBase {

        [HttpGet("/ServerApi/EmailServices/GetMessenger/{message}")]
        public async Task<string> GetMessenger(string message) {
            try {
                string result = null;
                if (!string.IsNullOrWhiteSpace(message)) result = CoreOperations.SendEmail(new SendMailRequest() { Content = message }, true);

                return JsonSerializer.Serialize(new ResMsg() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate(result) });
            } catch (Exception ex) { return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }

        [HttpPost("/ServerApi/EmailServices/PostMessenger")]
        [Consumes("application/json")]
        public async Task<string> PostMessenger([FromBody] SendMailRequest message) {
            try {
                string? result = null;
                if (!string.IsNullOrWhiteSpace(message.Content)) result = CoreOperations.SendEmail(message, true);

                return JsonSerializer.Serialize(new ResMsg() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate(result) });
            } catch (Exception ex) { return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }

        [HttpPost("/ServerApi/EmailServices/PostMassMesseger")]
        [Consumes("application/json")]
        public async Task<string> PostMassMesseger([FromBody] List<SendMailRequest> messages) {
            try {
                if (bool.Parse(DbOperations.GetServerParameterLists("ServiceEnableMassEmail").Value)) {
                    CoreOperations.SendMassEmail(messages);
                    return JsonSerializer.Serialize(new ResMsg() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate("emailsSent") });
                }
                else { return JsonSerializer.Serialize(new ResMsg() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate("massEmailNotEnabled") }); }
            } catch (Exception ex) { return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }
    }
}