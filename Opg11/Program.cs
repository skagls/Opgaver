using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg11
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v = new Vare();
            v.Navn = "vare # 1";
            v.Pris = 100;
            Console.WriteLine(v.PrisMedMoms());
            Vare v2 = new Vare("vare #2", 200);
            Console.WriteLine(v2.PrisMedMoms());

        }
    }
}
