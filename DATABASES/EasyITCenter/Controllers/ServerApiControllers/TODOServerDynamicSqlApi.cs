namespace EasyITCenter.ServerCoreDBSettings {

    /// <summary>
    /// Server Restart Api for Remote Control
    /// </summary>
    /// <seealso cref="ControllerBase"/>
    [Authorize]
    [ApiController]
    [Route("ServerApi")]
    //[ApiExplorerSettings(IgnoreApi = true)]
    public class ServerDynamicSqlApi : ControllerBase {

        [Authorize]
        [HttpPost("/ServerApi/DatabaseServices/RunSqlQuery/Sql/{slq}")]
        [Consumes("application/json")]
        public async Task<string> GetDynamicSql(string sqlquery) {
            try {
                if (ServerApiServiceExtension.IsAdmin()) {
                    var data = new EasyITCenterContext().EasyITCenterCollectionFromSql<GenericDataList>("EXEC " + sqlquery); ;

                    return JsonSerializer.Serialize(data, new JsonSerializerOptions() {
                        ReferenceHandler = ReferenceHandler.IgnoreCycles,
                        WriteIndented = true,
                        DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    });
                }
                else return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.DeniedYouAreNotAdmin.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate(DBResult.DeniedYouAreNotAdmin.ToString()) });
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        [Authorize]
        [HttpGet("/ServerApi/DatabaseServices/RunSqlQuery/ById/{id}")]
        public async Task<string> GetDynamicSqlById(int id) {
            try {
                if (ServerApiServiceExtension.IsAdmin()) {
                    var data = new EasyITCenterContext().EasyITCenterCollectionFromSql<GenericDataList>("EXEC "); ;

                    return JsonSerializer.Serialize(data, new JsonSerializerOptions() {
                        ReferenceHandler = ReferenceHandler.IgnoreCycles,
                        WriteIndented = true,
                        DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    });
                }
                else return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.DeniedYouAreNotAdmin.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate(DBResult.DeniedYouAreNotAdmin.ToString()) });
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }

        [Authorize]
        [HttpGet("/ServerApi/DatabaseServices/GetSavedQueries")]
        public async Task<string> GetSavedQueries() {
            try {
                if (ServerApiServiceExtension.IsAdmin()) {
                    var data = new EasyITCenterContext().EasyITCenterCollectionFromSql<GenericDataList>("EXEC "); ;

                    return JsonSerializer.Serialize(data, new JsonSerializerOptions() {
                        ReferenceHandler = ReferenceHandler.IgnoreCycles,
                        WriteIndented = true,
                        DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    });
                }
                else return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.DeniedYouAreNotAdmin.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate(DBResult.DeniedYouAreNotAdmin.ToString()) });
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }

        [Authorize]
        [HttpGet("/ServerApi/DatabaseServices/GetSavedQueryById/{id}")]
        public async Task<string> GetSavedQueryById(int id) {
            try {
                if (ServerApiServiceExtension.IsAdmin()) {
                    var data = new EasyITCenterContext().EasyITCenterCollectionFromSql<GenericDataList>("EXEC "); ;

                    return JsonSerializer.Serialize(data, new JsonSerializerOptions() {
                        ReferenceHandler = ReferenceHandler.IgnoreCycles,
                        WriteIndented = true,
                        DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    });
                }
                else return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.DeniedYouAreNotAdmin.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate(DBResult.DeniedYouAreNotAdmin.ToString()) });
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }

        [Authorize]
        [HttpGet("/ServerApi/DatabaseServices/SaveSqlQuery")]
        public async Task<string> SaveSqlQuery(string sql) {
            try {
                if (ServerApiServiceExtension.IsAdmin()) {
                    var data = new EasyITCenterContext().EasyITCenterCollectionFromSql<GenericDataList>("EXEC "); ;

                    return JsonSerializer.Serialize(data, new JsonSerializerOptions() {
                        ReferenceHandler = ReferenceHandler.IgnoreCycles,
                        WriteIndented = true,
                        DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    });
                }
                else return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.DeniedYouAreNotAdmin.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate(DBResult.DeniedYouAreNotAdmin.ToString()) });
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }

        [Authorize]
        [HttpGet("/ServerApi/DatabaseServices/GetTableData")]
        public async Task<string> GetTableData(string sql) {
            try {
                if (ServerApiServiceExtension.IsAdmin()) {
                    var data = new EasyITCenterContext().EasyITCenterCollectionFromSql<GenericDataList>("EXEC "); ;

                    return JsonSerializer.Serialize(data, new JsonSerializerOptions() {
                        ReferenceHandler = ReferenceHandler.IgnoreCycles,
                        WriteIndented = true,
                        DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    });
                }
                else return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.DeniedYouAreNotAdmin.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate(DBResult.DeniedYouAreNotAdmin.ToString()) });
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }

        [Authorize]
        [HttpGet("/ServerApi/DatabaseServices/GetTableSchema")]
        public async Task<string> GetTableSchema(string sql) {
            try {
                if (ServerApiServiceExtension.IsAdmin()) {
                    var data = new EasyITCenterContext().EasyITCenterCollectionFromSql<GenericDataList>("EXEC "); ;

                    return JsonSerializer.Serialize(data, new JsonSerializerOptions() {
                        ReferenceHandler = ReferenceHandler.IgnoreCycles,
                        WriteIndented = true,
                        DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    });
                }
                else return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.DeniedYouAreNotAdmin.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate(DBResult.DeniedYouAreNotAdmin.ToString()) });
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }
    }
}