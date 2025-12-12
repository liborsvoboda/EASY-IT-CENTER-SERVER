using FubarDev.FtpServer;
using FubarDev.FtpServer.AccountManagement;
using FubarDev.FtpServer.AccountManagement.Directories.RootPerUser;
using FubarDev.FtpServer.AccountManagement.Directories;
using FubarDev.FtpServer.FileSystem;
using Microsoft.Extensions.Options;

namespace EasyITCenter.ServerCoreServers {

    internal class HostedFtpServer : IHostedService {
        private readonly IFtpServerHost _ftpServerHost;

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedFtpServer"/> class.
        /// </summary>
        /// <param name="ftpServerHost">The FTP server host that gets wrapped as a hosted service.</param>
        public HostedFtpServer(
            IFtpServerHost ftpServerHost) {
            _ftpServerHost = ftpServerHost;
        }

        /// <inheritdoc/>
        public Task StartAsync(CancellationToken cancellationToken) {
            return _ftpServerHost.StartAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public Task StopAsync(CancellationToken cancellationToken) {
            return _ftpServerHost.StopAsync(cancellationToken);
        }
    }

    /// <summary>
    /// Custom membership provider for Authentication Validation Actual is Set by UserName and
    /// Password in Database
    /// </summary>
    public class HostedFtpServerMembershipProvider : IMembershipProvider {
        
        /// <summary>
        /// FTP User Validation Its for Open FTP and User Validation
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public MemberValidationResult ValidateUser(string username, string password) {
            if (!bool.Parse(DbOperations.GetServerParameterLists("ServerFtpSecurityEnabled").Value)) {
                return new MemberValidationResult(MemberValidationStatus.Anonymous, new CustomFtpUser("guest"));
            }
            else if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password)) {
                SolutionUserList? user = new EasyITCenterContext()
                    .SolutionUserLists.Include(a => a.Role).Where(a => a.Active == true && a.UserName == username && a.Password == password)
                    .First();
                if (user != null) { return new MemberValidationResult(MemberValidationStatus.AuthenticatedUser, new CustomFtpUser(username)); }
            }
            return new MemberValidationResult(MemberValidationStatus.InvalidLogin);
        }

        /// <summary>
        /// FTP User Validation Async Its for Open FTP and User Validation
        /// </summary>
        /// <param name="username">The user name.</param>
        /// <param name="password">The password.</param>
        /// <returns>The result of the validation.</returns>
        public async Task<MemberValidationResult> ValidateUserAsync(string username, string password) {
            if (!bool.Parse(DbOperations.GetServerParameterLists("ServerFtpSecurityEnabled").Value)) {
                return new MemberValidationResult(MemberValidationStatus.Anonymous, new CustomFtpUser("guest"));
            }
            else if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password)) {
                SolutionUserList? user = new EasyITCenterContext()
                    .SolutionUserLists.Include(a => a.Role).Where(a => a.Active == true && a.UserName == username && a.Password == password)
                    .First(); 
                if (user != null) { return new MemberValidationResult(MemberValidationStatus.AuthenticatedUser, new CustomFtpUser(username)); }
            }
            return new MemberValidationResult(MemberValidationStatus.InvalidLogin);
        }

        /// <summary>
        /// Custom FTP user implementation
        /// </summary>
        private class CustomFtpUser : IFtpUser {

            /// <summary>
            /// Initializes a new instance of the <see cref="CustomFtpUser"/> instance.
            /// </summary>
            /// <param name="name">The user name</param>
            public CustomFtpUser(string name) {
                Name = name;
            }

            /// <inheritdoc/>
            public string Name { get; }

            /// <inheritdoc/>
            public bool IsInGroup(string groupName) {
                // We claim that the user is in both the "user" group and in the a group with the
                // same name as the user name.
                return groupName == "user" || groupName == Name;
            }
        }
    }


    public class RootPerUserAccountDirectory : IAccountDirectoryQuery {
        private readonly ILogger<RootPerUserAccountDirectory> _logger;

        private readonly string _anonymousRoot;

        private readonly string _userRoot;

        private readonly bool _anonymousRootPerEmail;

        /// <summary>
        /// Initializes a new instance of the <see cref="RootPerUserAccountDirectoryQuery"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <param name="logger">The logger.</param>
        public RootPerUserAccountDirectory(
            IOptions<RootPerUserAccountDirectoryQueryOptions> options,
            ILogger<RootPerUserAccountDirectory> logger = null) {
            _logger = logger;
            _anonymousRoot = options.Value.AnonymousRootDirectory ?? string.Empty;
            _userRoot = options.Value.UserRootDirectory ?? string.Empty;
            _anonymousRootPerEmail = options.Value.AnonymousRootPerEmail;
        }

        /// <inheritdoc />
        public IAccountDirectories GetDirectories(IAccountInformation accountInformation) {
            if (accountInformation.FtpUser.IsAnonymous()) {
                return GetAnonymousDirectories(accountInformation.FtpUser);
            }

            var rootPath = Path.Combine(_userRoot, accountInformation.FtpUser.Identity.Name);
            return new GenericAccountDirectories(rootPath);
        }

        private IAccountDirectories GetAnonymousDirectories(ClaimsPrincipal ftpUser) {
            var rootPath = _anonymousRoot;
            if (_anonymousRootPerEmail) {
                var email = ftpUser.FindFirst(ClaimTypes.Name)?.Value;
                if (string.IsNullOrEmpty(email)) {
                    _logger?.LogWarning("Anonymous root per email is configured, but got anonymous user without email. This anonymous user will see the files of all other anonymous users!");
                } else {
                    rootPath = Path.Combine(rootPath, email);
                }
            }

            return new GenericAccountDirectories(rootPath);
        }
    }
}