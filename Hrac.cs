using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Whack_a_Mole
{
    internal class Hrac

    {
       public int zadaneCislo;


        public void Zasahni()
        {
            ConsoleKeyInfo userInput = Console.ReadKey();
            string hodnota = userInput.KeyChar.ToString();
            int cislo1;
            bool jeCislo = int.TryParse(hodnota, out cislo1);
            zadaneCislo = cislo1;
        }
    }
}
