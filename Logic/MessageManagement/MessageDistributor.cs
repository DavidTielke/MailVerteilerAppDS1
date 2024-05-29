using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MailVerteilerApp
{
    public class MessageDistributor : IMessageDistributor
    {
        private readonly IMessagePoller _poller;
        private readonly IReceiverManager _manager;
        private readonly IMessageSender _sender;

        public MessageDistributor(IMessagePoller poller, IReceiverManager manager, IMessageSender sender)
        {
            _poller = poller;
            _poller.NewMail += Distribute;
            _manager = manager;
            _sender = sender;
        }

        public void Start()
        {
            Console.WriteLine("Mailverteiler gestartet");
            _poller.Start();
        }

        public void Stop()
        {
            _poller.Stop();
            Console.WriteLine("Mailverteiler gestoppt");
        }

        public void Distribute()
        {
            Console.WriteLine("Verteilung wird gestartet");
            _manager.Load();
            _sender.Send();
            Console.WriteLine("Verteilung wurde beendet");
        }
    }
}