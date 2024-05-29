using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.DataAccess
{
    public class ReceiverRepository : IReceiverRepository
    {
        public void Load()
        {
            Console.WriteLine("Empfänger wurden ermittelt");
        }
    }
}