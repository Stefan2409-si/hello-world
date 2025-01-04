namespace ConsoleApp3
{
    public static class PomocneMetode
    {
        public static int Saberi(int prvi, int drugi)
        {
            return prvi + drugi;
        }

        public static int Oduzmi(int prvi, int drugi)
        {
            return prvi - drugi;
        }

        public static bool SadrziSlovo(string text, char slovo)
        {
            return text.Contains(slovo);
        }

        public static bool SadrziSolovoRucno(string text, char slovo)
        {
            foreach(char c in text)
            {
                if (c == slovo)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
