namespace EasyITCenter.ControllersExtensions {

    /// <summary>
    /// Simple Api for Checking Avaiability
    /// </summary>
    /// <seealso cref="ControllerBase"/>
    [ApiController]
    [Route("EasyITCenterBackendCheck")]
    public class EasyITCenterBackendCheckApi : ControllerBase {

        /// <summary>
        /// Gets the backend check API.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/EasyITCenterBackendCheck")]
        public Task<string> GetBackendCheckApi() { return Task.FromResult(DbOperations.DBTranslate("ServerRunning", DbOperations.GetServerParameterLists("ServiceServerLanguage").Value)); }
    }
}