namespace EasyITCenter.Controllers {

    [ApiController]
    [Route("EasyITCenterServerSettingList")]
    public class ServerSettingListApi : ControllerBase {

        [HttpGet("/EasyITCenterServerSettingList")]
        public async Task<string> GetServerSettingList() {
            List<ServerSettingList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            })) {
                data = new EasyITCenterContext().ServerSettingLists.OrderBy(a => a.Type).ThenBy(a => a.Key).ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/EasyITCenterServerSettingList/{key}")]
        public async Task<string> GetServerSettingListKey(string key) {
            ServerSettingList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted
            })) {
                data = new EasyITCenterContext().ServerSettingLists.Where(a => a.Key == key).First();
            }
            return JsonSerializer.Serialize(data);
        }

        [Authorize]
        [HttpPost("/EasyITCenterServerSettingList")]
        [Consumes("application/json")]
        public async Task<string> SetServerSettingListUpdate([FromBody] List<ServerSettingList> record) {
            try {
                if (ServerApiServiceExtension.IsAdmin()) {
                    int count = 0;
                    foreach (ServerSettingList item in record) {
                        var data = new EasyITCenterContext().ServerSettingLists.Update(item);
                        int result = await data.Context.SaveChangesAsync();
                        count += result;
                    }
                    if (count > 0) return JsonSerializer.Serialize(new ResMsg() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = count, ErrorMessage = string.Empty });
                    else return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = count, ErrorMessage = string.Empty });
                }
                else return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.DeniedYouAreNotAdmin.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate(DBResult.DeniedYouAreNotAdmin.ToString()) });
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }
    }
}