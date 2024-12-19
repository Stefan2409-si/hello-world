using System.Buffers;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prodavnica p1 = new Prodavnica()
            {
                Ime = "Prodavnica001",
                Proizvodi =
                [
                    new Proizvod()
                        {
                            Ime = "Proizvod1",
                            Boja = "Zuta"
                        },
                        new Proizvod()
                        {
                            Ime = "Proizvod2",
                            Boja = "Zelena"
                        }
                ]
            };
            Prodavnica p2 = new Prodavnica()
            {
                Ime = "Prodavnica002",
                Proizvodi = [
                    new Proizvod()
                    {
                        Ime = "Proizvod3",
                        Boja = "Plava"
                    },
                    new Proizvod()
                    {
                        Ime = "Proizvod4",
                        Boja = " Crna"
                    },
                     new Proizvod()
                    {
                        Ime = "Proizvod5",
                        Boja = "Bela"
                    }
                ]
            };

            p1.IspisiDetaljeProdavnice();
            p2.IspisiDetaljeProdavnice();
        }
    }
}
//trebas mi jednaklasa prodavnica svaka prodavnica ima proizvode i ime
// sve sto mi treba od klasa
// sa tako kreiranom klasom pravim objekat prodavnice pa drugi objekat prodavnice svakom objektu dodeljujem svoje ime i proizvode