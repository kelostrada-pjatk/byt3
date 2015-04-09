using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class WiezaKontrolna
    {
        private readonly HashSet<Samolot> _samoloty = new HashSet<Samolot>(); 

        public void RejestrujSamolot(Samolot samolot)
        {
            _samoloty.Add(samolot);
            samolot.ZarejestrujWieze(this);
        }

        public void WyslijWiadomosc(String wiadomosc, Vector3 pozycja, int odleglosc)
        {
            foreach (var samolot in _samoloty.Where(s => s.Pozycja.GetDistance(pozycja) < odleglosc))
            {
                samolot.OdbierzWiadomosc(wiadomosc);
            }
        }

    }
}
