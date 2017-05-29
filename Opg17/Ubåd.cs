using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg17
{
    class Ubåd :IDfunktioner
    {
        public int Nummer { get; set; }
        public double Tubine { get; set; }
        public void Gem()
            
            {
            Console.WriteLine("Gemmer ubåd...");
        }
    }
}
