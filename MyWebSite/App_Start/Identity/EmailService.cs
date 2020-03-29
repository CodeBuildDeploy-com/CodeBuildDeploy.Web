using System;
using System.Configuration;
using System.Net;
using System.Threading.Tasks;

using Microsoft.AspNet.Identity;

using NLog;

using SendGrid;

namespace MyWebSite.Identity
{
    public class EmailService : IIdentityMessageService
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public async Task SendAsync(IdentityMessage message)
        {
            await ConfigSendGridasync(message);
        }

        private async Task ConfigSendGridasync(IdentityMessage message)
        {
            try
            {
                var myMessage = new SendGridMessage();
                myMessage.AddTo(message.Destination);
                myMessage.From = new System.Net.Mail.MailAddress(
                                    ConfigurationManager.AppSettings["emailFromAccount"],
                                    ConfigurationManager.AppSettings["emailFromAccountName"]);
                myMessage.Subject = message.Subject;
                myMessage.Text = message.Body;
                myMessage.Html = message.Body;

                var credentials = new NetworkCredential(
                           ConfigurationManager.AppSettings["sendGridUserAccount"],
                           ConfigurationManager.AppSettings["sendGridPassword"]);

                var transportWeb = new Web(credentials);
                await transportWeb.DeliverAsync(myMessage);
                return;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Failed to create Web transport.");
            }
            await Task.FromResult(0);
        }
    }
}