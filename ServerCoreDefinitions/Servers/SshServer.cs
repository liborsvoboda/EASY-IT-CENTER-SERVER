using FoxSsh.Common;
using FoxSsh.Server;
using FubarDev.FtpServer;
using FubarDev.FtpServer.AccountManagement;
using FubarDev.FtpServer.AccountManagement.Directories;
using FubarDev.FtpServer.AccountManagement.Directories.RootPerUser;
using FubarDev.FtpServer.FileSystem;
using Microsoft.Extensions.Options;
using System.Text.RegularExpressions;

namespace EasyITCenter.ServerCoreServers
{

    public class Server
    {
        private static readonly SshServerSession _sshSession;
        private static readonly List<SandboxSession> _sessions = new();

        public static bool SSHServer()
        {
            SshServer server = new SshServer();

            server.ClientConnected += ClientConnectedHandler;
            server.ClientDisconnected += ClientDisconnectedHandler;
            server.Start();
            return true;
        }


        private static void ClientConnectedHandler(SshServerSession session)
        {
            var newSession = new SandboxSession(session);

            _sessions.Add(newSession);

            // newSession.Run();
        }

        private static void ClientDisconnectedHandler(SshServerSession session)
        {
            

            var oldSession = _sessions.FirstOrDefault(x => x.Id == session.Id);

            oldSession?.Stop();

            _sessions.Remove(oldSession);
        }


    }

    public class SandboxSession
    {
        private readonly SshServerSession _sshSession;


        public Guid Id => _sshSession.Id;

        public string Username { get; private set; }

        private readonly ILogger _logger;

        public SandboxSession(SshServerSession sshSession)
        {
            _sshSession = sshSession;
            _sshSession.AuthenticationRequest += AuthenticationRequestHandler;
            _sshSession.PtyRequest += PtyRegisteredHandler;
            _sshSession.Disconnected += Disconnected;
        }

        public void Stop()
        {
            //using var scope = _logger.BeginScope($"{GetType().Name}=>{MethodBase.GetCurrentMethod()?.Name}");
        }

        private void Disconnected(string obj)
        {
            //using var scope = _logger.BeginScope($"{GetType().Name}=>{MethodBase.GetCurrentMethod()?.Name}");

            Stop();
        }

        private void PtyRegisteredHandler(SshPty pty)
        {
            //using var scope = _logger.BeginScope($"{GetType().Name}=>{MethodBase.GetCurrentMethod()?.Name}");

        }

        private bool AuthenticationRequestHandler(SshAuthenticationRequest request)
        {
            //using var scope = _logger.BeginScope($"{GetType().Name}=>{MethodBase.GetCurrentMethod()?.Name}");

            request.Banner = $"Welcome {request.Username},\n\nYou have reached The FoxSSH Sandbox Server.\n\nPlease login...\n\n";

            //if (request.Method != SshCore.PasswordAuthenticationMethod)
            //{
            //    return false;
            //}

            request.IsSupportedMethod = true;

            if (request.Password != "hourglass")
            {
                return false;
            }

            Username = request.Username;

            return true;
        }
    }
}