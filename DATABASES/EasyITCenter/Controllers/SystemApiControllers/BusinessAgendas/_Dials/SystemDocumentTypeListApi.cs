namespace EasyITCenter.Controllers {

    [Authorize]
    [ApiController]
    [Route("EasyITCenterSystemDocumentTypeList")]
    public class EasyITCenterSystemDocumentTypeListApi : ControllerBase {

        [HttpGet("/EasyITCenterSystemDocumentTypeList")]
        public async Task<string> GetSystemDocumentTypeList() {
            List<SystemDocumentTypeList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            })) {
                data = new EasyITCenterContext().SystemDocumentTypeLists.ToList();
            }

            return JsonSerializer.Serialize(data, new JsonSerializerOptions() {ReferenceHandler = ReferenceHandler.IgnoreCycles,WriteIndented = true,DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
        }

        [HttpGet("/EasyITCenterSystemDocumentTypeList/Filter/{filter}")]
        public async Task<string> GetSystemDocumentTypeListByFilter(string filter) {
            List<SystemDocumentTypeList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            })) {
                data = new EasyITCenterContext().SystemDocumentTypeLists.FromSqlRaw("SELECT * FROM SystemDocumentTypeList WHERE 1=1 AND " + filter.Replace("+", " "))
                .AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data, new JsonSerializerOptions() {ReferenceHandler = ReferenceHandler.IgnoreCycles,WriteIndented = true,DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
        }

        [HttpGet("/EasyITCenterSystemDocumentTypeList/{id}")]
        public async Task<string> GetSystemDocumentTypeListKey(int id) {
            SystemDocumentTypeList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted
            })) {
                data = new EasyITCenterContext().SystemDocumentTypeLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data, new JsonSerializerOptions() {ReferenceHandler = ReferenceHandler.IgnoreCycles,WriteIndented = true,DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
        }

        [HttpPut("/EasyITCenterSystemDocumentTypeList")]
        [Consumes("application/json")]
        public async Task<string> InsertSystemDocumentTypeList([FromBody] SystemDocumentTypeList record) {
            try {
                if (ServerApiServiceExtension.IsAdmin()) {
                    //Check exist  translations
                    SystemTranslationList languageRec = new EasyITCenterContext().SystemTranslationLists.Where(a => a.SystemName == record.SystemName).FirstOrDefault();

                    //Insert translation before save new Document Type
                    if (languageRec == null) {
                        languageRec = new SystemTranslationList() { SystemName = record.SystemName, UserId = record.UserId, DescriptionCz = record.SystemName, DescriptionEn = record.SystemName };
                        await new EasyITCenterContext().SystemTranslationLists.Add(languageRec).Context.SaveChangesAsync();
                    }

                    record.User = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                    var data = new EasyITCenterContext().SystemDocumentTypeLists.Add(record);
                    int result = await data.Context.SaveChangesAsync();
                    if (result > 0) return JsonSerializer.Serialize(new ResMsg() { InsertedId = record.Id, Status = DBResult.success.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                    else return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                }
                else return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.DeniedYouAreNotAdmin.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate(DBResult.DeniedYouAreNotAdmin.ToString()) });
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/EasyITCenterSystemDocumentTypeList")]
        [Consumes("application/json")]
        public async Task<string> UpdateSystemDocumentTypeList([FromBody] SystemDocumentTypeList record) {
            try {
                if (ServerApiServiceExtension.IsAdmin()) {
                    var data = new EasyITCenterContext().SystemDocumentTypeLists.Update(record);
                    int result = await data.Context.SaveChangesAsync();
                    if (result > 0) return JsonSerializer.Serialize(new ResMsg() { InsertedId = record.Id, Status = DBResult.success.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                    else return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                }
                else return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.DeniedYouAreNotAdmin.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate(DBResult.DeniedYouAreNotAdmin.ToString()) });
            } catch (Exception ex) { return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/EasyITCenterSystemDocumentTypeList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteSystemDocumentTypeList(string id) {
            try {
                if (ServerApiServiceExtension.IsAdmin()) {
                    if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = "Id is not set" });

                    SystemDocumentTypeList record = new() { Id = int.Parse(id) };

                    var data = new EasyITCenterContext().SystemDocumentTypeLists.Remove(record);
                    int result = await data.Context.SaveChangesAsync();
                    if (result > 0) return JsonSerializer.Serialize(new ResMsg() { InsertedId = record.Id, Status = DBResult.success.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                    else return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                }
                else return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.DeniedYouAreNotAdmin.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate(DBResult.DeniedYouAreNotAdmin.ToString()) });
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }
    }
}