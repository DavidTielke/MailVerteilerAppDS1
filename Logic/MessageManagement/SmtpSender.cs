using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MailVerteilerApp
{
    public class SmtpSender : IMessageSender
    {
        private readonly IConfigurator _config;

        public SmtpSender(IConfigurator config)
        {
            _config = config;
        }

        public void Send()
        {
            var username = _config.Get<string>("SmtpUsername");
            var password = _config.Get<string>("SmtpPassword");
            var port = _config.Get<int>("SmtpPort", 931);

            Console.WriteLine($"Email wird SMtp verteilt (x mal): {username} {password}");
        }
    }
}