using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whack_a_Mole
{
    internal class Hrac

    {
       public int zadaneCislo;

        public void Zasahni()
        { 
        string hodnota1 = Console.ReadLine();
        int cislo1;
        bool jeCislo = int.TryParse(hodnota1, out cislo1);
        zadaneCislo = cislo1;
        }
    }
}
