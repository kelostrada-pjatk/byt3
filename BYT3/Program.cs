using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Mediator;
using Tickets;

namespace BYT3
{
    class Program
    {
        static void Calculator()
        {
            var ops = new Addition();
            ops.SetNext(new Substraction())
                .SetNext(new Multiplication())
                .SetNext(new Division());

            Console.WriteLine(ops.MakeCalculation(10, 3, OperationType.Multiply));
            Console.WriteLine(ops.MakeCalculation(10, 3, OperationType.Add));
            Console.WriteLine(ops.MakeCalculation(10, 3, OperationType.Substract));
            Console.WriteLine(ops.MakeCalculation(10, 3, OperationType.Divide));
        }

        static void Samolioty()
        {
            var rand = new Random();

            var wieza = new WiezaKontrolna();

            for (var i = 0; i < 100; i++)
            {
                wieza.RejestrujSamolot(new Samolot(new Vector3(rand.NextDouble() * 100, rand.NextDouble() * 100, rand.NextDouble() * 100)));
            }

            var samolotKela = new Samolot(new Vector3(0, 0, 0));

            wieza.RejestrujSamolot(samolotKela);

            samolotKela.WyslijWiadomosc("Siema ziomy", 30);
        }

        static void Tickets()
        {
            TicketStand pendolino = new Pendolino();

            var client = new Client(new DateTime(2000, 1, 1), 1000);
            
            pendolino.BuyTicket(client, new Trip() {Distance = 1000});
            pendolino.BuyTicket(client, new Trip() { Distance = 1000 });
            pendolino.BuyTicket(client, new Trip() { Distance = 1000 });
            pendolino.BuyTicket(client, new Trip() { Distance = 1000 });
            pendolino.BuyTicket(client, new Trip() { Distance = 1000 });
            pendolino.BuyTicket(client, new Trip() { Distance = 1000 });
            pendolino.BuyTicket(client, new Trip() { Distance = 1000 });
        }

        static void Main(string[] args)
        {
            //Calculator();
            //Samolioty();
            Tickets();
        }
    }
}
