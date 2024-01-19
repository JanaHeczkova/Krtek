namespace Whack_a_Mole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hrac hrac = new Hrac();
            Krtek krtek = new Krtek();
            Hra hra = new Hra();

            Console.WriteLine("Hra na krtka: Náhodně se zobrazují čísla od 0 do 9. Vaším úkolem je co nejrychleji zmáčknout uvedené číslo. Časový limit je 30 sekund.");
            Console.WriteLine("Jdeme na to! Zmáčkni ENTER");
            Console.ReadLine();
            Console.Clear();

            hra.Spustse();

            while (true)
            {
                hra.ZkontrolujCasovyLImit(krtek);
                {
                    if (hra.KonecHry)
                        return;
                }
                krtek.ObjevSe();

                hrac.Zasahni();
                krtek.BylJsemZasazen(hrac.zadaneCislo);
                Console.Clear();
            }
 
        }
    }
}