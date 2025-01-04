namespace ConsoleApp3
{
    public class Proizvod
    {
        public string Naziv { get; set; }
        public string KatBroj { get; set; }

        public void Ispisi()
        {
            Console.WriteLine($"[{KatBroj}] {Naziv}");
        }
    }
}
