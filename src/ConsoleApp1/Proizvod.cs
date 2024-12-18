using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Proizvod
    {
        public string Boja;
        public string Marka;
        public void Ispisi()
        {
            Console.WriteLine($"{Boja} - {Marka}");
        }
    }
}
