using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] månedsløn = { 10000, 20000, 15000, 20000, 30000, 15000 };
            double sum = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum += månedsløn[i];
            }
            double gns = sum / månedsløn.Length;

            for (int i = 0; i <månedsløn.Length; i++)
            {
                Console.WriteLine(månedsløn[i]);

            }

            Console.WriteLine("gennemsnit" + gns.ToString("N2"));
            

            Array.Sort(månedsløn);
            Console.ReadKey();

        }
    }
}
