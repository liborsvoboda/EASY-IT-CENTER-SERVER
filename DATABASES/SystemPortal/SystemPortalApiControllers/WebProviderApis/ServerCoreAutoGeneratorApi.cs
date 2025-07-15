using MySqlConnector;

namespace EasyITCenter.ControllersExtensions {

    /// <summary>
    /// Server Auto Cloner Controller
    /// </summary>
    [AllowAnonymous]
    [ApiController]
     //[ApiExplorerSettings(IgnoreApi = true)]
    public class ServerCoreAutoGeneratorApi : ControllerBase {

        [Authorize]
        [HttpPost("/CheckDBConnectionMSSQL")]
        public async Task<bool> CheckDBConnectionMSSQL([FromBody] AutoGenConnectionString connection) {
            bool check = false;
            try {
                SqlConnection cnn = new SqlConnection(connection.ConnectionString);
                await cnn.OpenAsync();
                if (cnn.State == System.Data.ConnectionState.Open) {
                    cnn.Close();
                    check = true;
                }
            } catch { }
            return check;
        }

        [Authorize]
        [HttpPost("/CheckDBConnectionMYSQL")]
        public async Task<bool> CheckDBConnectionMYSQL([FromBody] AutoGenConnectionString connection) {
            bool check = false;
            try {
                MySqlConnection cnn = new MySqlConnection(connection.ConnectionString);
                await cnn.OpenAsync();
                if (cnn.State == System.Data.ConnectionState.Open) {
                    cnn.Close();
                    check = true;
                }
            } catch { }
            return check;
        }

        /*
        [Authorize]
        [HttpGet("/ServerProcess")]
        public async Task<string> ServerProcess() {
            string result = "";
            try {
                if (CommunicationController.IsAdmin()) {
                    return JsonSerializer.Serialize(new DBResultMessage() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = ServerCoreDbOperations.DBTranslate("serverRestarting") });
                }
                else return JsonSerializer.Serialize(new DBResultMessage() { Status = DBResult.DeniedYouAreNotAdmin.ToString(), RecordCount = 0, ErrorMessage = ServerCoreDbOperations.DBTranslate(DBResult.DeniedYouAreNotAdmin.ToString()) });
            } catch (Exception ex) { return JsonSerializer.Serialize(new DBResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = ServerCoreFunctions.GetUserApiErrMessage(ex) }); }
        }
        */
    }
}