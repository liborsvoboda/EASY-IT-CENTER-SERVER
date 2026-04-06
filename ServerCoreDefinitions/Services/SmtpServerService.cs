using Microsoft.Extensions.Options;
using SmtpServer;
using SmtpServer.Authentication;
using SmtpServer.Mail;
using SmtpServer.Net;
using SmtpServer.Protocol;
using SmtpServer.Storage;
using System.Buffers;

namespace EasyITCenter.Services {

    public sealed class SmtpServerService : BackgroundService
    {
        public SmtpServerService(SmtpServer.SmtpServer smtpServer)
        {
            SrvRuntime.SmtpServerService = smtpServer;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            SrvRuntime.SmtpServerStatus = true;
            return SrvRuntime.SmtpServerService.StartAsync(stoppingToken);
        }


        public static void Shutdown(CancellationToken stoppingToken)
        {
            SrvRuntime.SmtpServerStatus = false;
            SrvRuntime.SmtpServerService.Shutdown();
        }
    }



    public sealed class EmailUserAuthenticator : UserAuthenticator
    {
        /// <summary>
        /// Authenticate a user account.
        /// </summary>
        /// <param name="context">The session context.</param>
        /// <param name="user">The user to authenticate.</param>
        /// <param name="password">The password of the user.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>true if the user is authenticated, false if not.</returns>
        public override Task<bool> AuthenticateAsync( ISessionContext context, string user, string password, CancellationToken cancellationToken)
        {
            SolutionUserList? data = new EasyITCenterContext().SolutionUserLists.Where(a=>a.UserName == user).FirstOrDefault();
            data = BCrypt.Net.BCrypt.Verify(password, data.Password) ? data : null;
            return Task.FromResult(data != null);
        }
    }



    public class EmailMessageStore : MessageStore
    {

        public EmailMessageStore() { }

        /// <summary>
        /// Save the given message to the underlying storage system.
        /// </summary>
        /// <param name="context">The session context.</param>
        /// <param name="transaction">The SMTP message transaction to store.</param>
        /// <param name="buffer">The buffer that contains the message content.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A unique identifier that represents this message in the underlying message store.</returns>
        public override async Task<SmtpResponse> SaveAsync(ISessionContext context, IMessageTransaction transaction, ReadOnlySequence<byte> buffer, CancellationToken cancellationToken)
        {
            await using var stream = new MemoryStream();

            var position = buffer.GetPosition(0);
            while (buffer.TryGet(ref position, out var memory))
            {
                stream.Write(memory.Span);
            }

            stream.Position = 0;

            var message = await MimeKit.MimeMessage.LoadAsync(stream, cancellationToken);

            //Outgoing Email
            //SolutionEmailerList record = new SolutionEmailerList() { EmailFolder = "IncomingEmail", From = message.From.ToString(), To = message.To.ToString(), ToCopy = message.Cc.ToString(), Subject = message.Subject, HtmlMessage = message.TextBody, Shown = false };
            //var data = new EasyITCenterContext().SolutionEmailerLists.Add(record);
            //data.Context.SaveChangesAsync();

            //Incoming Email
            SolutionEmailerList record = new SolutionEmailerList() { EmailFolder = "IncomingEmail", From = message.From.ToString(), To = message.To.ToString(), ToCopy =  message.Cc.ToString(), Subject = message.Subject, HtmlMessage = message.TextBody, Shown = false };
            var data = new EasyITCenterContext().SolutionEmailerLists.Add(record);
            data.Context.SaveChangesAsync();

            return SmtpResponse.Ok;
        }
    }


}
