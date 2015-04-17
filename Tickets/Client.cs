using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    public class Client
    {
        public Client(DateTime birthDate, decimal cash)
        {
            BirthDate = birthDate;
            Cash = cash;
        }

        public DateTime BirthDate { get; set; }
        private decimal _cash;

        public decimal Cash
        {
            get { return _cash; }
            set
            {
                if (value < 0) throw new Exception("Cannot set negative balance");
                _cash = value;
            }
        }

        public int Age
        {
            get { return DateTime.Now.Subtract(BirthDate).Days/365; }
        }
    }
}
