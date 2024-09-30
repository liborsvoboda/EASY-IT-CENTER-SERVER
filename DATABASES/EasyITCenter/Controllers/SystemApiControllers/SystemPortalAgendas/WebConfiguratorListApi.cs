namespace EasyITCenter.Controllers {

    [Authorize]
    [ApiController]
    [Route("EasyITCenterWebConfiguratorList")]
    public class EasyITCenterWebConfiguratorListApi : ControllerBase {

        //TODO MOVE TO LOCAL DIALS

        [HttpGet("/EasyITCenterWebConfiguratorList")]
        public async Task<string> GetWebConfiguratorList() {
            List<WebConfiguratorList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            })) {
                data = new EasyITCenterContext().WebConfiguratorLists
                    .OrderBy(a => a.IsStartupPage).ThenBy(a=>a.Name).ToList();
            }
            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/EasyITCenterWebConfiguratorList/Filter/{filter}")]
        public async Task<string> GetWebConfiguratorListByFilter(string filter) {
            List<WebConfiguratorList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            })) {
                data = new EasyITCenterContext().WebConfiguratorLists.FromSqlRaw("SELECT * FROM WebConfiguratorList WHERE 1=1 AND " + filter.Replace("+", " ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/EasyITCenterWebConfiguratorList/{id}")]
        public async Task<string> GetWebConfiguratorListKey(int id) {
            WebConfiguratorList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted
            })) {
                data = new EasyITCenterContext().WebConfiguratorLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/EasyITCenterWebConfiguratorList")]
        [Consumes("application/json")]
        public async Task<string> InsertWebConfiguratorList([FromBody] WebConfiguratorList record) {
            try {
                record.User = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                var data = new EasyITCenterContext().WebConfiguratorLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new ResMsg() { InsertedId = record.Id, Status = DBResult.success.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = result, ErrorMessage = string.Empty });
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/EasyITCenterWebConfiguratorList")]
        [Consumes("application/json")]
        public async Task<string> UpdateWebConfiguratorList([FromBody] WebConfiguratorList record) {
            try {
                var data = new EasyITCenterContext().WebConfiguratorLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new ResMsg() { InsertedId = record.Id, Status = DBResult.success.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = result, ErrorMessage = string.Empty });
            } catch (Exception ex) { return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/EasyITCenterWebConfiguratorList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteWebConfiguratorList(int id) {
            try {
                WebConfiguratorList record = new() { Id = id };
                var data = new EasyITCenterContext().WebConfiguratorLists.Remove(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new ResMsg() { InsertedId = record.Id, Status = DBResult.success.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = result, ErrorMessage = string.Empty });
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }
    }
}