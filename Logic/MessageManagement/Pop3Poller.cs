using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MailVerteilerApp
{
    public class Pop3Poller : IMessagePoller
    {
        private readonly IMailDownloader _mailDownloader;

        public event NewMessageDelegate NewMail;

        public Pop3Poller(IMailDownloader mailDownloader)
        {
            _mailDownloader = mailDownloader;
        }

        protected virtual void OnNewMail()
        {
            NewMail?.Invoke();
        }

        public void Start()
        {
            Console.WriteLine("Pop Polling gestartet");
            NewEmailDetected();
        }

        public void NewEmailDetected()
        {
            Console.WriteLine("Neue Email erkannt");
            _mailDownloader.DownloadMail();
            OnNewMail();
        }

        public void Stop()
        {
            Console.WriteLine("Pop Polling stoppen");
        }

    }
}