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
        public decimal Cash { get; set; }

        public int Age
        {
            get { return DateTime.Now.Subtract(BirthDate).Days/365; }
        }
    }
}
