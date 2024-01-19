using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whack_a_Mole
{
    internal class Hra
    {
        public bool KonecHry = false;
        public DateTime pocatecniCas;

        public void Spustse()
        {
            pocatecniCas = DateTime.Now;
        }

        public void ZkontrolujCasovyLImit(Krtek krtek)
        {
            DateTime aktualniCas = DateTime.Now;
            TimeSpan rozdil = aktualniCas - pocatecniCas;
            if (rozdil.TotalSeconds > 30)
            {
                Console.WriteLine($"Konec hry. Počet zásahů je: " + krtek.pocetZasahu);
                KonecHry = true;
            }
        }


    }
}
