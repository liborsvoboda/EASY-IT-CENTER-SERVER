namespace EasyITCenter.Controllers {

    /// <summary>
    /// WEBSocket Template still not used Ideal for Terminal Panels, chat, controlling services
    /// </summary>
    [AllowAnonymous]
    [ApiController]
    [Route("WebSocketService")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class WebSocketService : ControllerBase {
        private static ILogger<WebSocketService> _logger;

        public WebSocketService(ILogger<WebSocketService> logger) => _logger = logger;

        /// <summary>
        /// Universal WebSocket API Definitions for Connection Paths and Registering To Server
        /// Central List ow WebSocket Connections
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("/WebSocketService/{socketAPIPath}")]
        public async Task GetBySocketAPIPath(string socketAPIPath) {
            if (HttpContext.WebSockets.IsWebSocketRequest) {
                using WebSocket? webSocket = await HttpContext.WebSockets.AcceptWebSocketAsync();
                Managers.WebSocketManager.AddSocketConnectionToCentralList(webSocket, socketAPIPath);
                await Managers.WebSocketManager.ListenClientWebSocketMessages(webSocket, socketAPIPath);
            }
            else {
                HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }

        /// <summary>
        /// WebSocket Registration Connection API Example
        /// </summary>
        /// <returns></returns>
        [HttpGet("/WebSocketService")]
        public async Task Get() {
            if (HttpContext.WebSockets.IsWebSocketRequest) {
                using var webSocket = await HttpContext.WebSockets.AcceptWebSocketAsync();
                Managers.WebSocketManager.AddSocketConnectionToCentralList(webSocket, "");
                await Managers.WebSocketManager.ListenClientWebSocketMessages(webSocket, "");
                //await Echo(HttpContext, webSocket);
            }
            else {
                HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }

    }
}