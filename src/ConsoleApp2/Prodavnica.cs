using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Prodavnica
    {
        public string Ime;
        public Proizvod[] Proizvodi;
        
        public void IspisiDetaljeProdavnice()
        {
            Console.WriteLine(Ime);
            foreach (Proizvod p in Proizvodi)
            {
                p.IspisiDetaljeProizvoda();
            }
        }
    }
}

