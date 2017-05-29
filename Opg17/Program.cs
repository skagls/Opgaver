using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg17
{
    class Program
    {
        static void Main(string[] args)
        {
            IDfunktioner[] array = new IDfunktioner[4];
            array[0] = new Hund ();
            array[1] = new Ubåd ();
            array[2] = new Hund();
            array[3] = new Ubåd();

            foreach (var item in array)
            {
                item.Gem();
            }
            Console.ReadLine();
        }
    }
}
