using Microsoft.Graph.Models.Security;
using Renci.SshNet;
using ConnectionInfo = Renci.SshNet.ConnectionInfo;


namespace EasyITCenter.Controllers
{


    public class ExecuteCommandRequest
    {
        public string Host { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Key { get; set; } = null;
        public string Command { get; set; }
    }


    public class FileServiceRequest
    {
        public string Host { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Key { get; set; } = null;
        public string Command { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }

    }


    [Authorize]
    [ApiController]
    [Route("SSHService")]
     //[ApiExplorerSettings(IgnoreApi = true)]
    public class SSHService : ControllerBase {

        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hostingEnvironment;

        public SSHService(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment) {
            _hostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// Server Inteligent Documentation Generator Api StratupPath is WebFolder On Development is
        /// need WebRootPath WegbRootPath is Development Folder
        /// </summary>
        [HttpGet("/SSHService/GetCommands")]
        public async Task<string> GetCommands() {
            try {
                    
                
                return JsonSerializer.Serialize(new ResultMessage() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 1, ErrorMessage = string.Empty });
            } catch (Exception ex) { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }


        [HttpPost("/SSHService/ExecuteCommand")]
        public async Task<string> ExecuteCommand([FromBody] ExecuteCommandRequest executeCommandRequest)
        {
            try
            {
                var connectionInfo = executeCommandRequest.Key != null ? new ConnectionInfo(executeCommandRequest.Host, executeCommandRequest.Username, new PrivateKeyAuthenticationMethod(executeCommandRequest.Key))
                    : new ConnectionInfo(executeCommandRequest.Host, executeCommandRequest.Username, new PasswordAuthenticationMethod(executeCommandRequest.Username, executeCommandRequest.Password)); 
                SshClient sshclient = new SshClient(connectionInfo); 
                sshclient.Connect();
                SshCommand sc = sshclient.CreateCommand(executeCommandRequest.Command); //List Example: ls /tmp/doc
                sc.Execute();
                var result = sc.Result;
                if (sc.ExitStatus != 0) {
                    return JsonSerializer.Serialize(new ResultMessage() { Result = sc.Error, InsertedId = 0, Status = DBResult.error.ToString(), RecordCount = 1, ErrorMessage = string.Empty });
                } else { return JsonSerializer.Serialize(new ResultMessage() { Result = result, InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 1, ErrorMessage = string.Empty }); }
            }
            catch (Exception ex) { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }



        [HttpPost("/SSHService/FileService")]
        public async Task<string> FileService([FromBody] FileServiceRequest fileServiceRequest) {
            try
            {

                var connectionInfo = fileServiceRequest.Key != null ? new ConnectionInfo(fileServiceRequest.Host, fileServiceRequest.Username, new PrivateKeyAuthenticationMethod(fileServiceRequest.Key))
                    : new ConnectionInfo(fileServiceRequest.Host, fileServiceRequest.Username, new PasswordAuthenticationMethod(fileServiceRequest.Username, fileServiceRequest.Password));
                SftpClient sftpclient = new SftpClient(connectionInfo);
                sftpclient.Connect();

                dynamic result = null;
                switch (fileServiceRequest.Command)
                {
                    case "list":
                        result = sftpclient.ListDirectory(fileServiceRequest.Source);
                        break;
                    case "CreateDir":
                        sftpclient.CreateDirectory(fileServiceRequest.Source);
                        break;
                    case "CreateFile":
                        sftpclient.Create(fileServiceRequest.Source);
                        break;
                    case "Delete":
                        sftpclient.Delete(fileServiceRequest.Source);
                        break;
                    case "DownloadFile":
                        result = new StreamReader(fileServiceRequest.Source);
                        sftpclient.DownloadFile(fileServiceRequest.Target, result);
                        break;
                    case "UploadFile":
                        result = new StreamReader(fileServiceRequest.Source);
                        sftpclient.UploadFile(result, fileServiceRequest.Target);
                        break;
                    default:
                        break;
                }
                
                return JsonSerializer.Serialize(new ResultMessage() { Result = JsonSerializer.Serialize(result), InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 1, ErrorMessage = string.Empty });
            }
            catch (Exception ex) { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }

    }
}