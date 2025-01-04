namespace ConsoleApp3
{
    public class Prodavnica
    {
        public string Naziv { get; set; }
        private List<Proizvod> Proizvodi { get; set; } = new List<Proizvod>();

        public void DodajProizvod(Proizvod p)
        {
            Proizvodi.Add(p);
        }

        public void IzlistajProizvode()
        {
            foreach(Proizvod p in Proizvodi)
            {
                p.Ispisi();
            }
        }
    }
}
