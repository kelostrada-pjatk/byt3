using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    public class Ticket
    {
        public Trip Trip { get; set; }
        public int Place { get; set; }
        public decimal Price { get; set; }
    }
}
