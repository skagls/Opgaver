using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() { Efternavn = "x", Fornavn = "x" };
            Person e = new Elev() { Efternavn = "z", Fornavn = "z", KlasseLokale = "A" };
            Person i = new Indstruktør() { Efternavn = "y", Fornavn = "y", NøgleId = 1 };
            p.Skriv();
            e.Skriv();
            i.Skriv();

            Person[] lst = new Person[3];
            lst[0] = p;
            lst[1] = e;
            lst[2] = i;
            foreach (var item in lst)
                item.Skriv();
        }
    }
}
