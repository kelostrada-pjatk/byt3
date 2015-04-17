using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    public abstract class TicketStand
    {
        private readonly Dictionary<Client, List<Ticket>> _clientsDatabase = new Dictionary<Client, List<Ticket>>();

        protected List<Ticket> GetClientTickets(Client client)
        {
            if (!_clientsDatabase.ContainsKey(client))
            {
                _clientsDatabase.Add(client, new List<Ticket>());
            }
            return _clientsDatabase[client];
        }

        public void AddTicketToClient(Client client, Ticket ticket)
        {
            GetClientTickets(client).Add(ticket);
        }

        protected abstract string Name { get; }
        protected abstract int GetFreePlaceNumber(Trip trip);
        protected abstract decimal CalculateTicketPrice(Client client, Trip trip, int place);
        protected abstract void ProcessPayment(Client client, decimal amount);

        public Ticket BuyTicket(Client client, Trip trip)
        {
            var place = GetFreePlaceNumber(trip);
            var price = CalculateTicketPrice(client, trip, place);
            ProcessPayment(client, price);

            var ticket = new Ticket
            {
                Place = place,
                Trip = trip,
                Price = price
            };

            AddTicketToClient(client, ticket);

            Console.WriteLine("{0} ticket bought, price: {1:0.00}", Name, price);

            return ticket;
        }

    }
}
