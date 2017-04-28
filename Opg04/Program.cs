using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg04
{
    class Program
    {
        static void Main(string[] args)
        {
            String fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletnavn = $"{fornavn} {efternavn}";
            Console.WriteLine(samletnavn);

            string navnStort = samletnavn.ToUpper();
            Console.WriteLine(navnStort);
            string navnLille = samletnavn.ToLower();
            Console.WriteLine(navnLille);

            String del = samletnavn.Substring(7, 4);
            Console.WriteLine(del);

            String[] navne = samletnavn.Split(' ');
            foreach (var item in navne)
            Console.WriteLine(item);

            Console.ReadKey();


        }
    }
}
