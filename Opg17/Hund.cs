using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg17
{
    class Hund : IDfunktioner
    {
        public string Navn { get; set; }

        public void Gem()
    {
        Console.WriteLine("Gemmer hund...");
    }

    }
}
