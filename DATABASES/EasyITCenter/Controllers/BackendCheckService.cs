namespace EasyITCenter.Controllers {

    /// <summary>
    /// Simple Api for Checking Avaiability
    /// </summary>
    /// <seealso cref="ControllerBase"/>
    [ApiController]
    [Route("BackendCheckService")]
    public class BackendCheckService : ControllerBase {

        /// <summary>
        /// Gets the backend check API.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/BackendCheckService")]
        public Task<string> GetBackendCheckApi() { return Task.FromResult(DbOperations.DBTranslate("ServerRunning", DbOperations.GetServerParameterLists("ServiceServerLanguage").Value)); }


        [HttpGet("/BackendCheckDbService")]
        public Task<string> GetBackendCheckDbApi() {
            if (new EasyITCenterContext().Database.CanConnect()) {
                return Task.FromResult(DbOperations.DBTranslate("DatabaseIsConnected", DbOperations.GetServerParameterLists("ServiceServerLanguage").Value));
            } else { return Task.FromResult(DbOperations.DBTranslate("DatabaseIsNotConnected", DbOperations.GetServerParameterLists("ServiceServerLanguage").Value)); }
        }
    }
}