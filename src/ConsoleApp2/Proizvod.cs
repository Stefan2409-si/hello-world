using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Proizvod
    {
        public string Ime;
        public string Boja;
        public void IspisiDetaljeProizvoda()
        {
            Console.WriteLine($"- {Ime} - {Boja}");
        }
    }
}
