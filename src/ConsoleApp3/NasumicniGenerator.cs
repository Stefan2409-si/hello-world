namespace ConsoleApp3
{
    public static class NasumicniGenerator
    {
        private static List<string> _imena = new List<string>()
        {
            "Aleksa",
            "Marko",
            "Stefan",
            "Nikola",
            "Slave",
            "Lazar",
            "Dejan",
            "Uros"
        };

        private static List<string> _prezimena = new List<string>()
        {
            "Ristic",
            "Nikolic",
            "Bambic",
            "Lukic",
            "Jovic",
            "Cvetkovic",
            "Radivojevic"
        };

        public static string GenerisiIme()
        {
            return _imena[System.Random.Shared.Next(0, _imena.Count)];
        }

        public static string GenerisiPrezime()
        {
            return _prezimena[System.Random.Shared.Next(0, _prezimena.Count)];
        }

        public static string GenerisiPunoImeIPrezime()
        {
            string ime = GenerisiIme();
            string prezime = GenerisiPrezime();

            return ime + " " + prezime;
        }

        public static Proizvod GenerisiNasumicniProizvod()
        {
            Proizvod p = new Proizvod();
            p.Naziv = GenerisiIme();
            p.KatBroj = GenerisiKataloskiBroj();
            return p;
        }

        public static string GenerisiKataloskiBroj()
        {
            string karakteri = "asdfghjklqwertyuiopzxcvbnm1234567890";
            string katBr = "";
            for(int i = 0; i < 3; i++)
            {
                katBr += karakteri[System.Random.Shared.Next(karakteri.Length)];
            }

            katBr += "-";
            for (int i = 0; i < 3; i++)
            {
                katBr += karakteri[System.Random.Shared.Next(karakteri.Length)];
            }

            return katBr;
        }
    }
}
