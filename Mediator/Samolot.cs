using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Samolot
    {
        private static int _sekwencja = 0;

        protected int Id { get; set; }

        private WiezaKontrolna _wiezaKontrolna;

        public Vector3 Pozycja { get; set; }

        public Samolot(Vector3 pozycja)
        {
            Id = _sekwencja++;
            Pozycja = pozycja;
        }

        public void ZarejestrujWieze(WiezaKontrolna wiezaKontrolna)
        {
            _wiezaKontrolna = wiezaKontrolna;
        }

        public void WyslijWiadomosc(String wiadomosc, int odleglosc)
        {
            _wiezaKontrolna.WyslijWiadomosc(wiadomosc, Pozycja, odleglosc);
        }

        public void OdbierzWiadomosc(String wiadomosc)
        {
            Console.WriteLine("Samolot o ID: {0} odebral wiadomosc: {1}, Moja pozycja: {2}", Id, wiadomosc, Pozycja);
        }

    }
}
