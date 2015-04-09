using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    public class Pendolino : TicketStand
    {
        private readonly Random _random = new Random();

        private const decimal MaxDiscount = 30;

        private decimal MakeDiscount(decimal price, int count)
        {
            return price - price * ( -1/(count + 1/MaxDiscount) + MaxDiscount) / 100;
        }


        protected override int GetFreePlaceNumber(Trip trip)
        {
            return _random.Next(100);
        }


        protected override decimal CalculateTicketPrice(Client client, Trip trip, int place)
        {
            // LUCKY <3
            if (place == 1) return 1;

            var price = (decimal)Math.Sqrt((double)trip.Distance);

            price = MakeDiscount(price, GetClientTickets(client).Count);

            return price;
        }

        protected override void ProcessPayment(Client client, decimal amount)
        {
            client.Cash -= amount;
        }
    }
}
