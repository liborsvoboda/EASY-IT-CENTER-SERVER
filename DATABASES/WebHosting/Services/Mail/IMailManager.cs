using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyITCenter.Services {

    public class MailManagerOptions {
        public string EmailProvider { get; set; }
        public string SupportTeamEmail { get; set; }
        public string SupportTeamName { get; set; }
    }

    public interface IMailManager
    {
        Task SendEmailAsync(string email, string subject, string message);
    }

    public class EmptyMailManager : IMailManager {
        public EmptyMailManager(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public Task SendEmailAsync(string email, string subject, string message) {
            return Task.CompletedTask;
        }
    }

}
