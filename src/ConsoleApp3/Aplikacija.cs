namespace ConsoleApp3
{
    public static class Aplikacija
    {
        public static void StartujStaticno()
        {
            string nekoNasumicnoIme = NasumicniGenerator.GenerisiIme();
            Console.WriteLine("Evo nasumicnog imena: " + nekoNasumicnoIme);

            string nekoNasumicnoPrezime = NasumicniGenerator.GenerisiPrezime();
            Console.WriteLine("Evo nasumicnog prezimena: " + nekoNasumicnoPrezime);

            int a = 1;
            int b = 2;
            int zbir = PomocneMetode.Saberi(a, b);
            Console.WriteLine("Evo zbira: " + zbir);

            char slovo = 'n';
            string text = "Neki tekst ovo ono";
            if (PomocneMetode.SadrziSlovo(text, slovo))
            {
                Console.WriteLine("Sadrzi slovo " + slovo);
            }
            else
            {
                Console.WriteLine("Ne sadrzai slovo " + slovo);
            }
        }
        public static void StartujObjektno()
        {
            Prodavnica p = new Prodavnica();
            p.Naziv = "Maxi";

            for (int i = 0; i < 20; i++)
            {
                p.DodajProizvod(NasumicniGenerator.GenerisiNasumicniProizvod());
            }

            p.IzlistajProizvode();
        }
    }
}
