using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whack_a_Mole
{
    internal class Krtek
    {
        public int nahodneCislo;

        public void ObjevSe()
        {
        Random generatorNahodnychCisel = new Random();
         nahodneCislo = generatorNahodnychCisel.Next(10);
         Console.WriteLine(nahodneCislo);
        }

        public int pocetZasahu = 0;

        public void BylJsemZasazen(int zadaneCislo)
        {
            if (nahodneCislo == zadaneCislo)
            {
                pocetZasahu++;
            }
            else
            {
                Console.Beep();
            }
        }
    }
}
