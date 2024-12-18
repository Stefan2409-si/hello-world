using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class App
    {
        Proizvod[] Niz = [
            new Proizvod()
            {
                Boja = "Plava",
                Marka = "ford"
            },
            new Proizvod()
            {
                Boja = "Crvena",
                Marka = "Golf"
            }
            ];
        public void Start()
        {
            foreach(Proizvod a in Niz)
            {
                a.Ispisi();
            }
            
        }
    }
}
