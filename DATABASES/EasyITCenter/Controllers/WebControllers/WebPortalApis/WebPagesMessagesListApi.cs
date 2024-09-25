namespace EasyITCenter.Controllers {

    [ApiController]
    [Route("/WebApi/WebPages")]
     //[ApiExplorerSettings(IgnoreApi = true)]
    public class WebPagesMessagesListApi : ControllerBase {

        //[Authorize]
        /// <summary>
        /// Inserts the web page messages list.
        /// </summary>
        /// <param name="webdata">The webdata.</param>
        /// <returns></returns>
        [HttpPost("/WebApi/WebPages/InsertMessage")]
        [Consumes("application/json")]
        public async Task<string> InsertWebPageMessagesList([FromBody] WebMessage webdata) {
            try {
                string name = DateTimeOffset.Now.UtcDateTime.ToString();
                WebMessagesList record = new() { Name = name, Description = webdata.Message, UserId = 1, Active = true, TimeStamp = DateTimeOffset.Now.DateTime };
                var data = new EasyITCenterContext().WebMessagesLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new ResMsg() { InsertedId = record.Id, Status = DBResult.success.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = result, ErrorMessage = string.Empty });
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }

        /// <summary>
        /// Gets the web page messages list.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/WebApi/WebPages/GetMessageList")]
        public async Task<string> GetWebPageMessagesList() {
            List<WebMessagesList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            })) {
                data = new EasyITCenterContext().WebMessagesLists.OrderByDescending(a => a.TimeStamp).ToList();
            }

            return JsonSerializer.Serialize(data);
        }
    }
}