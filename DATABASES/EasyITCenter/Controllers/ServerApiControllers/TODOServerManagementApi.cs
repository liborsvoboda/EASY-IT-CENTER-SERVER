﻿using Quartz;
using System.Threading;

namespace EasyITCenter.ServerCoreDBSettings {

    /// <summary>
    /// Server Services Remote Control
    /// </summary>
    /// <seealso cref="ControllerBase"/>
    [ApiController]
    //[ApiExplorerSettings(IgnoreApi = true)]
    [Route("ServerApi")]
    public class ServerApiManagementServicesApi : ControllerBase {
        private readonly ILogger logger;
        public ServerApiManagementServicesApi(ILogger<ServerApiManagementServicesApi> _logger) => logger = _logger;


        /// <summary>
        /// Scheduler Server Controls
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet("/ServerApi/ManagementServices/SchedulerStart")]
        public async Task<IActionResult> ServerSchedulerStart() {
            try {
                if (ServerApiServiceExtension.IsAdmin()) {
                    if (SrvRuntime.SrvScheduler != null) { await SrvRuntime.SrvScheduler.ResumeAll(); }
                    return Ok(JsonSerializer.Serialize(new ResMsg() { Status = DBResult.success.ToString(), ErrorMessage = string.Empty }));
                }
                else { return BadRequest(new ResMsg() { Status = DBResult.error.ToString(), ErrorMessage = DbOperations.DBTranslate("YouDoesNotHaveRights") }); }
            } catch (Exception ex) { return BadRequest(new ResMsg() { Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }

        /// <summary>
        /// Scheduler Server Stop
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet("/ServerApi/ManagementServices/SchedulerStop")]
        public async Task<IActionResult> ServerSchedulerStop() {
            try {
                if (ServerApiServiceExtension.IsAdmin()) {
                    if (SrvRuntime.SrvScheduler != null) { await SrvRuntime.SrvScheduler.PauseAll(); }
                    return Ok(JsonSerializer.Serialize(new ResMsg() { Status = DBResult.success.ToString(), ErrorMessage = string.Empty }));
                }
                else { return BadRequest(new ResMsg() { Status = DBResult.error.ToString(), ErrorMessage = DbOperations.DBTranslate("YouDoesNotHaveRights") }); }
            } catch (Exception ex) { return BadRequest(new ResMsg() { Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }

        /// <summary>
        /// Scheduler Server Start
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("/ServerApi/ManagementServices/SchedulerStatus")]
        public async Task<IActionResult> ServerSchedulerStatus() {
            try {
                if (ServerApiServiceExtension.IsAdmin()) {
                    return Ok(JsonSerializer.Serialize(new ResMsg() { 
                        Status = (SrvRuntime.SrvScheduler == null || await SrvRuntime.SrvScheduler.IsTriggerGroupPaused("AutoScheduler"))
                        ? ServerStatusTypes.Stopped.ToString() : ServerStatusTypes.Running.ToString(), ErrorMessage = string.Empty }));
                }
                else { return BadRequest(new ResMsg() { Status = DBResult.error.ToString(), ErrorMessage = DbOperations.DBTranslate("YouDoesNotHaveRights") }); }
            } catch (Exception ex) { return BadRequest(new ResMsg() { Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }


        /// <summary>
        /// Core Server Restart Control Api
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet("/ServerApi/ManagementServices/CoreServerRestart")]
        public async Task<string> ServerRestart() {
            try {
                if (ServerApiServiceExtension.IsAdmin()) {
                    EICServer.RestartServer();

                    return JsonSerializer.Serialize(new ResMsg() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate("serverRestarting") });
                }
                else return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.DeniedYouAreNotAdmin.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate(DBResult.DeniedYouAreNotAdmin.ToString()) });
            } catch (Exception ex) { return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }


        /// <summary>
        /// FtpServerStart Api
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet("/ServerApi/ManagementServices/FtpServerStart")]
        public async Task<string> FtpServerStart() {
            try {
                if (ServerApiServiceExtension.IsAdmin()) {
                    if (SrvRuntime.ServerFTPProvider != null) {
                        SrvRuntime.FTPSrvStatus = true;
                        await SrvRuntime.ServerFTPProvider.StartAsync(); 
                    }

                    return JsonSerializer.Serialize(new ResMsg() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate("serverRestarting") });
                }
                else return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.DeniedYouAreNotAdmin.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate(DBResult.DeniedYouAreNotAdmin.ToString()) });
            } catch (Exception ex) { return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }

        /// <summary>
        /// FtpServerStop Api
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet("/ServerApi/ManagementServices/FtpServerStop")]
        public async Task<string> FtpServerStop() {
            try {
                if (ServerApiServiceExtension.IsAdmin()) {
                    if (SrvRuntime.ServerFTPProvider != null) {
                        SrvRuntime.FTPSrvStatus = false;
                        await SrvRuntime.ServerFTPProvider.StopAsync();
                    }

                    return JsonSerializer.Serialize(new ResMsg() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate("serverRestarting") });
                }
                else return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.DeniedYouAreNotAdmin.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate(DBResult.DeniedYouAreNotAdmin.ToString()) });
            } catch (Exception ex) { return JsonSerializer.Serialize(new ResMsg() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }



        /// <summary>
        /// FTP Server Status
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("/ServerApi/ManagementServices/FtpServerStatus")]
        public async Task<IActionResult> FtpServerStatus() {
            try {
                return Ok(JsonSerializer.Serialize(new ResMsg() { Status = !SrvRuntime.FTPSrvStatus ? ServerStatusTypes.Stopped.ToString() : ServerStatusTypes.Running.ToString(), ErrorMessage = string.Empty }));
            } catch (Exception ex) { return BadRequest(new ResMsg() { Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }

    }
}