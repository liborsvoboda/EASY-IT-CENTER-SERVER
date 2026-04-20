using WatsonWebsocket;
using WatsonWebserver;
using ReverseMarkdown.Converters;
using Tcp.NET.Server;
using Tcp.NET.Server.Models;
using WatsonTcp;
using XmlDocMarkdown.Core;
using static EasyITCenter.Controllers.GeneratorService;
using Voltaic;
using WatsonWebserver.Core;


namespace EasyITCenter.Controllers {

    /// <summary>
    /// Server Routing Rulles
    /// </summary>
    [AllowAnonymous]
    [Route("ServerService")]
    [ApiController]
    //[ApiExplorerSettings(IgnoreApi = true)]
    public class ServerService : ControllerBase {
        
        public class SocketServerRequest {
            public int Port { get; set; }
            public bool SSLenabled { get; set; }
            public bool CertificatePassword { get; set; } = false;
        }


        public class TcpServerRequest {
            public int Port { get; set; }
            public bool CertificatePassword { get; set; } = false;
        }


        public class WebServerRequest {
            public int Port { get; set; }
            public bool SSLenabled { get; set; }
            public bool CertificatePassword { get; set; } = false;
        }

        
        /// <summary>
        /// ONLY SERVER Outgoing Messages
        /// https://github.com/dotnet/WatsonWebserver
        /// </summary>
        /// <param name="tcpServerRequest"></param>
        /// <returns></returns>
        [HttpPost("/ServerService/CreateTcpServer")]
        public async Task<IActionResult> CreateTcpServer([FromBody] TcpServerRequest tcpServerRequest) {
            try {

                if (HttpContextExtension.IsAdmin() || HttpContextExtension.IsWebAdmin()) {
                    var server = new WatsonTcpServer("0.0.0.0", tcpServerRequest.Port, CoreOperations.GetSelfSignedCertificate(DbOperations.GetServerParameterLists("ConfigCertificatePassword").Value),TlsVersion.Tls12);

                    
                    server.Start();

                    return base.Ok(new WebClasses.JsonResult() { Result = string.Empty, Status = DBResult.success.ToString() });
                } else {
                    return base.Ok(new WebClasses.JsonResult() { Result = String.Empty, Status = DBResult.UnauthorizedRequest.ToString() });
                }
            } catch (Exception ex) {
                return base.Ok(new WebClasses.JsonResult() { Result = DataOperations.GetErrMsg(ex), Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetErrMsg(ex) });
            }
            
        }


        
        /// <summary>
        /// FULL SEVRER FULL REST + WEBSOCKET + STREAM + ROUTES
        /// https://github.com/dotnet/WatsonWebserver
        /// </summary>
        /// <param name="webServerRequest"></param>
        /// <returns></returns>
        [HttpPost("/ServerService/CreateWebServer")]
        public async Task<IActionResult> CreateWebServer([FromBody] WebServerRequest webServerRequest) {
            try {

                if (HttpContextExtension.IsAdmin() || HttpContextExtension.IsWebAdmin()) {
                    WebserverSettings? setting = new WebserverSettings("0.0.0.0", webServerRequest.Port, webServerRequest.SSLenabled);

                    if (webServerRequest.SSLenabled) { setting.Ssl.SslCertificate = CoreOperations.GetSelfSignedCertificate(DbOperations.GetServerParameterLists("ConfigCertificatePassword").Value); }

                    
                    Webserver server = new Webserver( setting, DefaultRequest);
                    await server.StartAsync();


                    static async Task DefaultRequest(HttpContextBase ctx) {
                        Console.WriteLine(ctx.Request.DataAsString);

                        ctx.Response.ContentType = "application/json";
                        await ctx.Response.Send(default);

                            ctx.Timestamp.End = DateTime.UtcNow;

                            Console.WriteLine(
                                ctx.Request.Source.IpAddress + ":" + ctx.Request.Source.Port + " " +
                                ctx.Request.Method.ToString() + " " + ctx.Request.Url.RawWithQuery + " " +
                                ctx.Request.ContentLength + " bytes " +
                                "(" + ctx.Timestamp.TotalMs + "ms)");
                        
                    }

                    return base.Ok(new WebClasses.JsonResult() { Result = string.Empty, Status = DBResult.success.ToString() });
                } else {
                    return base.Ok(new WebClasses.JsonResult() { Result = String.Empty, Status = DBResult.UnauthorizedRequest.ToString() });
                }
            } catch (Exception ex) {
                return base.Ok(new WebClasses.JsonResult() { Result = DataOperations.GetErrMsg(ex), Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetErrMsg(ex) });
            }

        }


        /// <summary>
        /// SEND/RECEIVE MESSAGES
        /// https://github.com/LiveOrDevTrying/Tcp.NET?tab=readme-ov-file#tcpnetserver
        /// </summary>
        /// <param name="tcpServerRequest"></param>
        /// <returns></returns>
        [HttpPost("/ServerService/CreateTcpNetServer")]
        public async Task<IActionResult> CreateTcpNetServer([FromBody] TcpServerRequest tcpServerRequest) {
            try {

                if (HttpContextExtension.IsAdmin() || HttpContextExtension.IsWebAdmin()) {

                    byte[] certificate = System.IO.File.ReadAllBytes("cert.pfx");
                    string certificatePassword = "yourCertificatePassword";
                    TcpNETServer? server = new TcpNETServer(new ParamsTcpServer(tcpServerRequest.Port, "\r\n", connectionSuccessString: "Connected Successfully"), certificate, DbOperations.GetServerParameterLists("ConfigCertificatePassword").Value);

                    await server.StartAsync();

                    return base.Ok(new WebClasses.JsonResult() { Result = string.Empty, Status = DBResult.success.ToString() });
                } else {
                    return base.Ok(new WebClasses.JsonResult() { Result = String.Empty, Status = DBResult.UnauthorizedRequest.ToString() });
                }
            } catch (Exception ex) {
                return base.Ok(new WebClasses.JsonResult() { Result = DataOperations.GetErrMsg(ex), Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetErrMsg(ex) });
            }

        }


        /// <summary>
        /// ONLY INCOMING MESSAGES
        /// https://github.com/jchristn/WatsonWebsocket
        /// </summary>
        /// <param name="socketServerRequest"></param>
        /// <returns></returns>
        [HttpPost("/ServerService/CreateSocketServer")]
        public async Task<IActionResult> CreateSocketServer([FromBody] SocketServerRequest socketServerRequest) {
            try {

                if (HttpContextExtension.IsAdmin() || HttpContextExtension.IsWebAdmin()) {

                    WatsonWsServer server = new WatsonWsServer("0.0.0.0", socketServerRequest.Port, socketServerRequest.SSLenabled);
                    server.ClientConnected += ClientConnected;
                    server.ClientDisconnected += ClientDisconnected;
                    server.MessageReceived += MessageReceived;
                    
                    await server.StartAsync();


                    return base.Ok(new WebClasses.JsonResult() { Result = string.Empty, Status = DBResult.success.ToString() });
                } else {
                    return base.Ok(new WebClasses.JsonResult() { Result = String.Empty, Status = DBResult.UnauthorizedRequest.ToString() });
                }
            } catch (Exception ex) {
                return base.Ok(new WebClasses.JsonResult() { Result = DataOperations.GetErrMsg(ex), Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetErrMsg(ex) });
            }

        }

        static void ClientConnected(object sender, WatsonWebsocket.ConnectionEventArgs args)
        {
            Console.WriteLine("Client connected: " + args.Client.ToString());
        }

        static void ClientDisconnected(object sender, WatsonWebsocket.DisconnectionEventArgs args)
        {
            Console.WriteLine("Client disconnected: " + args.Client.ToString());
        }

        static void MessageReceived(object sender, WatsonWebsocket.MessageReceivedEventArgs args)
        {
            Console.WriteLine("Message received from " + args.Client.ToString() + ": " + Encoding.UTF8.GetString(args.Data));
        }


        
        /// <summary>
        /// METHOD IN/OUT Server 
        /// https://github.com/jchristn/Voltaic
        /// </summary>
        /// <param name="socketServerRequest"></param>
        /// <returns></returns>
        [HttpPost("/ServerService/CreateJsonServer")]
        public async Task<IActionResult> CreateJsonServer([FromBody] SocketServerRequest socketServerRequest) {
            try {

                if (HttpContextExtension.IsAdmin() || HttpContextExtension.IsWebAdmin()) {

                    JsonRpcServer server = new JsonRpcServer(IPAddress.Any, socketServerRequest.Port);

                    // Subscribe to events
                    server.ClientConnected += (sender, e) =>
                Console.WriteLine($"Client connected:");

                    server.RequestReceived += (sender, e) =>
                        Console.WriteLine($"Request: {e.Method} from {e.Client.SessionId}");

                    server.ResponseSent += (sender, e) =>
                        Console.WriteLine($"Response: {e.Method} took {e.Duration.TotalMilliseconds}ms");

                    // Register a synchronous method
                    server.RegisterMethod("greet", (JsonElement? args) =>
                    {
                        string? name = args?.TryGetProperty("name", out JsonElement nameEl) == true
                            ? nameEl.GetString()
                            : "World";
                        return $"Hello, {name}!";
                    });

                    // Register an asynchronous method (for I/O-bound work like DB queries, HTTP calls, etc.)
                    server.RegisterMethod("fetchData", async (JsonElement? args) =>
                    {
                        // Async handlers avoid blocking the thread pool
                        await Task.Delay(100); // Simulate async work
                        return (object)"async result";
                    });

                    // Register an async method with cancellation support
                    server.RegisterMethod("longRunningTask", async (JsonElement? args, CancellationToken token) => {
                        // The token is the server's connection processing token
                        await Task.Delay(5000, token); // Cancels if client disconnects
                        return (object)"completed";
                    });

                    // Start the server
                    await server.StartAsync();


                    return base.Ok(new WebClasses.JsonResult() { Result = string.Empty, Status = DBResult.success.ToString() });
                } else {
                    return base.Ok(new WebClasses.JsonResult() { Result = String.Empty, Status = DBResult.UnauthorizedRequest.ToString() });
                }
            } catch (Exception ex) {
                return base.Ok(new WebClasses.JsonResult() { Result = DataOperations.GetErrMsg(ex), Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetErrMsg(ex) });
            }

        }


        
        /// <summary>
        /// IN/OUT SCHEMA DEFINED SERVER
        /// https://github.com/jchristn/Voltaic
        /// </summary>
        /// <returns></returns>
        [HttpGet("/ServerService/CreateMCPServer")]
        public async Task<IActionResult> CreateMCPServer() {
            try {

                if (HttpContextExtension.IsAdmin() || HttpContextExtension.IsWebAdmin()) {

                    McpServer server = new McpServer(true);

                    // Customize server identity (optional)
                    server.ServerName = "MyMcpServer";
                    server.ServerVersion = "2.0.0";

                    // Register a tool with metadata for MCP tool discovery
                    server.RegisterTool("add",
                        "Adds two numbers",
                        new {
                            type = "object",
                            properties = new {
                                a = new { type = "number", description = "First number" },
                                b = new { type = "number", description = "Second number" }
                            },
                            required = new[] { "a", "b" }
                        },
                        (JsonElement? args) => {
                            double a = args?.TryGetProperty("a", out JsonElement aEl) == true ? aEl.GetDouble() : 0;
                            double b = args?.TryGetProperty("b", out JsonElement bEl) == true ? bEl.GetDouble() : 0;
                            return (object)( a + b );
                        });

                    // Built-in methods are registered automatically:
                    // - initialize (returns capabilities and serverInfo)
                    // - tools/list (returns all registered tools)
                    // - tools/call (invokes a tool by name)
                    // - notifications/initialized (handles client init notification)
                    // - ping, echo, getTime (utility tools)

                    // Run the server (reads from stdin, writes to stdout)
                    await server.RunAsync();


                    return base.Ok(new WebClasses.JsonResult() { Result = string.Empty, Status = DBResult.success.ToString() });
                } else {
                    return base.Ok(new WebClasses.JsonResult() { Result = String.Empty, Status = DBResult.UnauthorizedRequest.ToString() });
                }
            } catch (Exception ex) {
                return base.Ok(new WebClasses.JsonResult() { Result = DataOperations.GetErrMsg(ex), Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetErrMsg(ex) });
            }

        }



        /// <summary>
        /// IN/OUT METHOD SERVER
        /// </summary>
        /// <param name="socketServerRequest"></param>
        /// <returns></returns>
        [HttpPost("/ServerService/CreateMcpTcpServer")]
        public async Task<IActionResult> CreateMcpTcpServer([FromBody] SocketServerRequest socketServerRequest) {
            try {

                if (HttpContextExtension.IsAdmin() || HttpContextExtension.IsWebAdmin()) {

                    McpTcpServer server = new McpTcpServer(IPAddress.Any, socketServerRequest.Port);

                    // Subscribe to events
                    server.ClientConnected += (sender, client) =>
                        Console.WriteLine($"Client connected: {client.SessionId}");

                    server.ClientDisconnected += (sender, client) =>
                        Console.WriteLine($"Client disconnected: {client.SessionId}");

                    // Register a method (tools/call dispatches to registered methods by name)
                    server.RegisterMethod("add", (JsonElement? args) =>
                    {
                        double a = args?.TryGetProperty("a", out JsonElement aEl) == true ? aEl.GetDouble() : 0;
                        double b = args?.TryGetProperty("b", out JsonElement bEl) == true ? bEl.GetDouble() : 0;
                        return (object)( a + b );
                    });

                    // Register tools/list so clients can discover available tools
                    server.RegisterMethod("tools/list", (JsonElement? args) =>
                    {
                        return new {
                            tools = new[]
                            {
            new
            {
                name = "add",
                description = "Adds two numbers",
                inputSchema = new
                {
                    type = "object",
                    properties = new
                    {
                        a = new { type = "number", description = "First number" },
                        b = new { type = "number", description = "Second number" }
                    },
                    required = new[] { "a", "b" }
                }
            }
        }
                        };
                    });

                    // Start the server
                    await server.StartAsync();

                    return base.Ok(new WebClasses.JsonResult() { Result = string.Empty, Status = DBResult.success.ToString() });
                } else {
                    return base.Ok(new WebClasses.JsonResult() { Result = String.Empty, Status = DBResult.UnauthorizedRequest.ToString() });
                }
            } catch (Exception ex) {
                return base.Ok(new WebClasses.JsonResult() { Result = DataOperations.GetErrMsg(ex), Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetErrMsg(ex) });
            }

        }


        /// <summary>
        /// IN/OUT SESSION SEVER + ROUTE
        /// https://github.com/jchristn/Voltaic
        /// </summary>
        /// <param name="socketServerRequest"></param>
        /// <returns></returns>
        [HttpPost("/ServerService/CreateMcpHttpServer")]
        public async Task<IActionResult> CreateMcpHttpServer([FromBody] SocketServerRequest socketServerRequest) {
            try {

                if (HttpContextExtension.IsAdmin() || HttpContextExtension.IsWebAdmin()) {

                    McpHttpServer server = new McpHttpServer("0.0.0.0", socketServerRequest.Port);

                    // Subscribe to events
                    server.ClientConnected += (sender, client) =>
                        Console.WriteLine($"Session started: {client.SessionId}");

                    server.RequestReceived += (sender, e) =>
                        Console.WriteLine($"Request: {e.Method} from session {e.Client.SessionId}");

                    // Register a tool (automatically added to tools/list and tools/call)
                    server.RegisterTool("add",
                        "Adds two numbers",
                        new {
                            type = "object",
                            properties = new {
                                a = new { type = "number", description = "First number" },
                                b = new { type = "number", description = "Second number" }
                            },
                            required = new[] { "a", "b" }
                        },
                        (JsonElement? args) => {
                            double a = args?.TryGetProperty("a", out JsonElement aEl) == true ? aEl.GetDouble() : 0;
                            double b = args?.TryGetProperty("b", out JsonElement bEl) == true ? bEl.GetDouble() : 0;
                            return (object)( a + b );
                        });

                    // Start the server
                    await server.StartAsync();

                    return base.Ok(new WebClasses.JsonResult() { Result = string.Empty, Status = DBResult.success.ToString() });
                } else {
                    return base.Ok(new WebClasses.JsonResult() { Result = String.Empty, Status = DBResult.UnauthorizedRequest.ToString() });
                }
            } catch (Exception ex) {
                return base.Ok(new WebClasses.JsonResult() { Result = DataOperations.GetErrMsg(ex), Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetErrMsg(ex) });
            }

        }



        /// <summary>
        /// IN/OUT ClieNT SERVER 
        /// https://github.com/jchristn/Voltaic
        /// </summary>
        /// <param name="socketServerRequest"></param>
        /// <returns></returns>
        [HttpPost("/ServerService/CreateMcpWebsocketsServer")]
        public async Task<IActionResult> CreateMcpWebsocketsServer([FromBody] SocketServerRequest socketServerRequest) {
            try {

                if (HttpContextExtension.IsAdmin() || HttpContextExtension.IsWebAdmin()) {

                    McpWebsocketsServer server = new McpWebsocketsServer("localhost", socketServerRequest.Port);

                    // Subscribe to events
                    server.ClientConnected += (sender, client) =>
                        Console.WriteLine($"WebSocket client connected: {client.SessionId}");

                    server.ResponseSent += (sender, e) =>
                        Console.WriteLine($"Sent response for {e.Method} in {e.Duration.TotalMilliseconds}ms");

                    // Register a method (tools/call dispatches to registered methods by name)
                    server.RegisterMethod("add", (JsonElement? args) =>
                    {
                        double a = args?.TryGetProperty("a", out JsonElement aEl) == true ? aEl.GetDouble() : 0;
                        double b = args?.TryGetProperty("b", out JsonElement bEl) == true ? bEl.GetDouble() : 0;
                        return (object)( a + b );
                    });

                    // Register tools/list so clients can discover available tools
                    server.RegisterMethod("tools/list", (JsonElement? args) =>
                    {
                        return new {
                            tools = new[]
                            {
                                new
                                {
                                    name = "add",
                                    description = "Adds two numbers",
                                    inputSchema = new
                                    {
                                        type = "object",
                                        properties = new
                                        {
                                            a = new { type = "number", description = "First number" },
                                            b = new { type = "number", description = "Second number" }
                                        },
                                        required = new[] { "a", "b" }
                                    }
                                }
                            }
                        };
                    });

                    // Start the server
                    await server.StartAsync();

                    return base.Ok(new WebClasses.JsonResult() { Result = string.Empty, Status = DBResult.success.ToString() });
                } else {
                    return base.Ok(new WebClasses.JsonResult() { Result = String.Empty, Status = DBResult.UnauthorizedRequest.ToString() });
                }
            } catch (Exception ex) {
                return base.Ok(new WebClasses.JsonResult() { Result = DataOperations.GetErrMsg(ex), Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetErrMsg(ex) });
            }

        }


    }
        
}