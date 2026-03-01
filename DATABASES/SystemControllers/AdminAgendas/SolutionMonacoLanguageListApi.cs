using EasyITCenter.DBModel;

namespace EasyITCenter.Controllers {

    
    [ApiController]
    [Route("EasyITCenterSolutionMonacoLanguageList")]
    public class SolutionMonacoLanguageListApi : ControllerBase {


        [AllowAnonymous]
        [HttpGet("/EasyITCenterSolutionMonacoLanguageList")]
        public async Task<string> GetEasyITCenterSolutionMonacoLanguageList() {
            List<SolutionMonacoSuggestionList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            })) {
                data = new EasyITCenterContext().SolutionMonacoSuggestionLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }


        [AllowAnonymous]
        [HttpGet("/EasyITCenterSolutionMonacoLanguageList/Filter/{filter}")]
        public async Task<string> GetEasyITCenterSolutionMonacoLanguageListByFilter(string filter) {
            List<SolutionMonacoSuggestionList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            })) {
                data = new EasyITCenterContext().SolutionMonacoSuggestionLists.FromSqlRaw("SELECT * FROM SolutionMonacoSuggestionLists WHERE 1=1 AND " + filter.Replace("+", " ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }


        [AllowAnonymous]
        [HttpGet("/EasyITCenterSolutionMonacoLanguageList/{id}")]
        public async Task<string> GetEasyITCenterSolutionMonacoLanguageListKey(int id) {
            SolutionMonacoSuggestionList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted
            })) {
                data = new EasyITCenterContext().SolutionMonacoSuggestionLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }


        [Authorize]
        [HttpPut("/EasyITCenterSolutionMonacoLanguageList")]
        [Consumes("application/json")]
        public async Task<string> InsertEasyITCenterSolutionMonacoLanguageList([FromBody] SolutionMonacoSuggestionList record) {
            try {
                if (HtttpContextExtension.IsWebAdmin() || HtttpContextExtension.IsAdmin()) {
                    EntityEntry<SolutionMonacoSuggestionList>? data = new EasyITCenterContext().SolutionMonacoSuggestionLists.Add(record);
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
        [HttpPost("/EasyITCenterSolutionMonacoLanguageList")]
        [Consumes("application/json")]
        public async Task<string> UpdateEasyITCenterSolutionMonacoLanguageList([FromBody] SolutionMonacoSuggestionList record) {
            try {
                if (HtttpContextExtension.IsWebAdmin() || HtttpContextExtension.IsAdmin()) {
                    EntityEntry<SolutionMonacoSuggestionList>? data = new EasyITCenterContext().SolutionMonacoSuggestionLists.Update(record);
                    int result = await data.Context.SaveChangesAsync();
                    if (result > 0) return JsonSerializer.Serialize(new ResultMessage() { InsertedId = record.Id, Status = DBResult.success.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                    else return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                }
                else return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.DeniedYouAreNotAdmin.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate(DBResult.DeniedYouAreNotAdmin.ToString()) });
            } catch (Exception ex) { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }


        [Authorize]
        [HttpDelete("/EasyITCenterSolutionMonacoLanguageList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteEasyITCenterSolutionMonacoLanguageList(string id) {
            try {
                if (HtttpContextExtension.IsWebAdmin() || HtttpContextExtension.IsAdmin()) {
                    if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = "Id is not set" });

                    SolutionMonacoSuggestionList record = new() { Id = int.Parse(id) };

                    EntityEntry<SolutionMonacoSuggestionList>? data = new EasyITCenterContext().SolutionMonacoSuggestionLists.Remove(record);
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