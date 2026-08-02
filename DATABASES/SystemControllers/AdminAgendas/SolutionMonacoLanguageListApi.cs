using EasyITCenter.DBModel;

namespace EasyITCenter.Controllers {

    
    [ApiController]
    [Route("EasyITCenterSharedMonacoLanguageList")]
    public class SharedMonacoLanguageListApi : ControllerBase {


        [AllowAnonymous]
        [HttpGet("/EasyITCenterSharedMonacoLanguageList")]
        public async Task<string> GetEasyITCenterSharedMonacoLanguageList() {
            List<SharedMonacoSuggestionList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            })) {
                data = new EasyITCenterContext().SharedMonacoSuggestionLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }


        [AllowAnonymous]
        [HttpGet("/EasyITCenterSharedMonacoLanguageList/Filter/{filter}")]
        public async Task<string> GetEasyITCenterSharedMonacoLanguageListByFilter(string filter) {
            List<SharedMonacoSuggestionList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            })) {
                data = new EasyITCenterContext().SharedMonacoSuggestionLists.FromSqlRaw("SELECT * FROM SharedMonacoSuggestionLists WHERE 1=1 AND " + filter.Replace("+", " ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }


        [AllowAnonymous]
        [HttpGet("/EasyITCenterSharedMonacoLanguageList/{id}")]
        public async Task<string> GetEasyITCenterSharedMonacoLanguageListKey(int id) {
            SharedMonacoSuggestionList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted
            })) {
                data = new EasyITCenterContext().SharedMonacoSuggestionLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }


        [Authorize]
        [HttpPut("/EasyITCenterSharedMonacoLanguageList")]
        [Consumes("application/json")]
        public async Task<string> InsertEasyITCenterSharedMonacoLanguageList([FromBody] SharedMonacoSuggestionList record) {
            try {
                if (HttpContextExtension.IsWebAdmin() || HttpContextExtension.IsAdmin() || HttpContextExtension.IsSuperAdmin()) {
                    EntityEntry<SharedMonacoSuggestionList>? data = new EasyITCenterContext().SharedMonacoSuggestionLists.Add(record);
                    int result = await data.Context.SaveChangesAsync();
                    if (result > 0) return JsonSerializer.Serialize(new ResultMessage() { InsertedId = record.Id, Status = DBResult.success.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                    else return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                }
                else return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.DeniedYouAreNotAdmin.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate(DBResult.DeniedYouAreNotAdmin.ToString()) });
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        [Authorize]
        [HttpPost("/EasyITCenterSharedMonacoLanguageList")]
        [Consumes("application/json")]
        public async Task<string> UpdateEasyITCenterSharedMonacoLanguageList([FromBody] SharedMonacoSuggestionList record) {
            try {
                if (HttpContextExtension.IsWebAdmin() || HttpContextExtension.IsAdmin() || HttpContextExtension.IsSuperAdmin()) {
                    EntityEntry<SharedMonacoSuggestionList>? data = new EasyITCenterContext().SharedMonacoSuggestionLists.Update(record);
                    int result = await data.Context.SaveChangesAsync();
                    if (result > 0) return JsonSerializer.Serialize(new ResultMessage() { InsertedId = record.Id, Status = DBResult.success.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                    else return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                }
                else return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.DeniedYouAreNotAdmin.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate(DBResult.DeniedYouAreNotAdmin.ToString()) });
            } catch (Exception ex) { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }


        [Authorize]
        [HttpDelete("/EasyITCenterSharedMonacoLanguageList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteEasyITCenterSharedMonacoLanguageList(string id) {
            try {
                if (HttpContextExtension.IsWebAdmin() || HttpContextExtension.IsAdmin() || HttpContextExtension.IsSuperAdmin()) {
                    if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = "Id is not set" });

                    SharedMonacoSuggestionList record = new() { Id = int.Parse(id) };

                    EntityEntry<SharedMonacoSuggestionList>? data = new EasyITCenterContext().SharedMonacoSuggestionLists.Remove(record);
                    int result = await data.Context.SaveChangesAsync();
                    if (result > 0) return JsonSerializer.Serialize(new ResultMessage() { InsertedId = record.Id, Status = DBResult.success.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                    else return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                }
                else return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.DeniedYouAreNotAdmin.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate(DBResult.DeniedYouAreNotAdmin.ToString()) });
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }
    }
}