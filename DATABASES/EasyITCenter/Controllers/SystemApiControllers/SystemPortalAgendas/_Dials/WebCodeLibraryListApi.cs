namespace EasyITCenter.Controllers {

    [Authorize]
    [ApiController]
    [Route("EasyITCenterWebCodeLibraryList")]
    public class EasyITCenterWebCodeLibraryListApi : ControllerBase {

        [HttpGet("/EasyITCenterWebCodeLibraryList")]
        public async Task<string> GetWebCodeLibraryList() {
            List<WebCodeLibraryList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            })) {
                data = new EasyITCenterContext().WebCodeLibraryLists.OrderBy(a => a.Name).ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/EasyITCenterWebCodeLibraryList/Filter/{filter}")]
        public async Task<string> GetWebCodeLibraryListByFilter(string filter) {
            List<WebCodeLibraryList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            })) {
                data = new EasyITCenterContext().WebCodeLibraryLists.FromSqlRaw("SELECT * FROM WebCodeLibraryList WHERE 1=1 AND " + filter.Replace("+", " ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }


        [HttpGet("/EasyITCenterWebCodeLibraryList/ByGroup/{code}")]
        public async Task<string> GetWebCodeLibraryListGroup(string code) {
            List<WebCodeLibraryList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted
            })) {
                data = new EasyITCenterContext().WebCodeLibraryLists
                    .Where(a =>
                    (code.ToLower() == "web" && (a.InheritedCodeType.ToLower() == "html" || a.InheritedCodeType.ToLower() == "javascript" || a.InheritedCodeType.ToLower() == "css")
                    || a.InheritedCodeType.ToLower() == code.ToLower()) && a.IsCompletion).OrderBy(a => a.InheritedCodeType).ThenBy(a=>a.Name).ToList();
            }

            return JsonSerializer.Serialize(data);
        }


        [HttpGet("/EasyITCenterWebCodeLibraryList/{id}")]
        public async Task<string> GetWebCodeLibraryListKey(int id) {
            WebCodeLibraryList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted
            })) {
                data = new EasyITCenterContext().WebCodeLibraryLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/EasyITCenterWebCodeLibraryList")]
        [Consumes("application/json")]
        public async Task<string> InsertWebCodeLibraryList([FromBody] WebCodeLibraryList record) {
            try {
                var data = new EasyITCenterContext().WebCodeLibraryLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new ResMsg() { InsertedId = record.Id, Status = DBResult.success.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = result, ErrorMessage = string.Empty });
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/EasyITCenterWebCodeLibraryList")]
        [Consumes("application/json")]
        public async Task<string> UpdateWebCodeLibraryList([FromBody] WebCodeLibraryList record) {
            try {
                var data = new EasyITCenterContext().WebCodeLibraryLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new ResMsg() { InsertedId = record.Id, Status = DBResult.success.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = result, ErrorMessage = string.Empty });
            } catch (Exception ex) { return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/EasyITCenterWebCodeLibraryList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteWebCodeLibraryList(string id) {
            try {
                if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = "Id is not set" });

                WebCodeLibraryList record = new() { Id = int.Parse(id) };

                var data = new EasyITCenterContext().WebCodeLibraryLists.Remove(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new ResMsg() { InsertedId = record.Id, Status = DBResult.success.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = result, ErrorMessage = string.Empty });
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }
    }
}