using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gebeurtenissen
{
    internal class BouwerMetLog
    {
        public event LogEventHandler Klaar;  // Definieer de gebeurtenis Klaar

        protected void AlsKlaar(string bericht)
        {
            if (Klaar != null)  // Als de klassegebruiker (een) methoden heeft toegevoegd aan de gebeurtenis
                Klaar(bericht); // worden deze methoden uitgevoerd met de parameter "bericht"
        }

        internal void SchepZand(int werknemers = 1)
        {
            Console.WriteLine("Bezig met zand scheppen");
            AlsKlaar("Klaar met zand scheppen");  // provoceer de gebeurtenis Klaar met de gegeven parameter
        }

        internal void PlaatsSchutting(int werknemers = 1)
        {
            Console.WriteLine("Bezig met het plaatsen van een schutting");
            AlsKlaar("Klaar met schutting zetten"); // provoceer de gebeurtenis Klaar met de gegeven parameter
        }

        internal void PintjePakken(int werknemers = 1)
        {
            Console.WriteLine("Even een pintje drinken");
            AlsKlaar("Pintje is op");  // provoceer de gebeurtenis Klaar met de gegeven parameter
        }
    }
}
