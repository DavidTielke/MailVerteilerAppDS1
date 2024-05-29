using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.DataAccess;

namespace MailVerteilerApp
{
    public class ReceiverManager : IReceiverManager
    {
        private IReceiverRepository _repository;

        public ReceiverManager(IReceiverRepository repository)
        {
            _repository = repository;
        }

        public void Load()
        {
            _repository.Load();
        }
    }
}