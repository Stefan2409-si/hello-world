using System.Runtime.CompilerServices;

namespace Zadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int zbir = SaberiDvaBroja(a, b);
            Console.WriteLine("Evo ga zbir " + zbir);
        }
        
        static void IspisiNasumicnoIme()
        {
            List<string> mogucaImena = new List<string>()
            {
                "Marko",
                "Stefan",
                "aleksa",
                "Nikola",
                "Lazar"
            };

            Console.WriteLine(mogucaImena[System.Random.Shared.Next(mogucaImena.Count)]);
        }

        static string GenerisiNasumicnoIme()
        {
            List<string> mogucaImena = new List<string>()
            {
                "Marko",
                "Stefan",
                "aleksa",
                "Nikola",
                "Lazar"
            };

            return mogucaImena[System.Random.Shared.Next(mogucaImena.Count)];
        }

        static int SaberiDvaBroja(int prvi, int drugi)
        {
            Console.WriteLine("Pripremite se!!! Sabiram dva broja!!!");
            return prvi + drugi;
        }

        static int PodeliDvaBroja(int prvi, int drugi)
        {
            return prvi / drugi;
        }


    }
}