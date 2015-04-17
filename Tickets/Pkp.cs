using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    public class Pkp : TicketStand
    {
        private readonly Dictionary<Trip, int> _trips = new Dictionary<Trip, int>();

        protected override string Name
        {
            get { return "PKP"; }
        }

        protected override int GetFreePlaceNumber(Trip trip)
        {
            if (!_trips.ContainsKey(trip))
            {
                _trips.Add(trip, 1);
            }
            else
            {
                _trips[trip]++;
            }
            return _trips[trip];
        }

        protected override decimal CalculateTicketPrice(Client client, Trip trip, int place)
        {
            var dec = (decimal)Math.Sqrt((double) trip.Distance);
            return (30 - client.Age + 2*place)/100M*dec + 20;
        }

        protected override void ProcessPayment(Client client, decimal amount)
        {
            client.Cash -= amount;
        }
    }
}
