namespace EasyITCenter.Controllers {

    [Authorize]
    [ApiController]
    [Route("EasyITCenterSolutionWebsiteList")]
    public class EasyITCenterSolutionWebsiteListApi : ControllerBase {

        [HttpGet("/EasyITCenterSolutionWebsiteList")]
        public async Task<string> GetSolutionWebsiteList() {
            List<SolutionWebsiteList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            })) {
                data = new EasyITCenterContext().SolutionWebsiteLists.ToList();
            }
            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/EasyITCenterSolutionWebsiteList/Filter/{filter}")]
        public async Task<string> GetSolutionWebsiteListByFilter(string filter) {
            List<SolutionWebsiteList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            })) {
                data = new EasyITCenterContext().SolutionWebsiteLists.FromSqlRaw("SELECT * FROM SolutionWebsiteList WHERE 1=1 AND " + filter.Replace("+", " ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/EasyITCenterSolutionWebsiteList/{id}")]
        public async Task<string> GetSolutionWebsiteListKey(int id) {
            SolutionWebsiteList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted
            })) {
                data = new EasyITCenterContext().SolutionWebsiteLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/EasyITCenterSolutionWebsiteList")]
        [Consumes("application/json")]
        public async Task<string> InsertSolutionWebsiteList([FromBody] SolutionWebsiteList record) {
            try {
                record.User = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                var data = new EasyITCenterContext().SolutionWebsiteLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new ResMsg() { InsertedId = record.Id, Status = DBResult.success.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = result, ErrorMessage = string.Empty });
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/EasyITCenterSolutionWebsiteList")]
        [Consumes("application/json")]
        public async Task<string> UpdateSolutionWebsiteList([FromBody] SolutionWebsiteList record) {
            try {
                var data = new EasyITCenterContext().SolutionWebsiteLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new ResMsg() { InsertedId = record.Id, Status = DBResult.success.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = result, ErrorMessage = string.Empty });
            } catch (Exception ex) { return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/EasyITCenterSolutionWebsiteList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteSolutionWebsiteList(int id) {
            try {
                SolutionWebsiteList record = new() { Id = id };
                var data = new EasyITCenterContext().SolutionWebsiteLists.Remove(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new ResMsg() { InsertedId = record.Id, Status = DBResult.success.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = result, ErrorMessage = string.Empty });
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }
    }
}