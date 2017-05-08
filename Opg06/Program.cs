using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg06
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine(res); //7
            double res2 = BeregnAreal(5);
            Console.WriteLine(res2); //78.5398
            Udskriv();
            Udskriv("Dette er en test");
            double res3 = BeregmMoms(100.35);
            Console.WriteLine(res3); //25.0875

            double res4 = BeregmMoms(100.35, 0.25);
            Console.WriteLine(res3); //25.0875
            int[] løn = { 10000, 5000, 30000 };
            double gns = Gennemsnit(løn);
            Console.WriteLine(gns); //15.000


        }
        static double Gennemsnit(int []månedsløn)
        {
            double sum = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum += månedsløn[i];

            }
            return sum / månedsløn.Length;

        }
        static double BeregmMoms(double tal,double momsPct=0.25)
        {
            return tal * momsPct;

        }
        static int LægSammen (int a, int b)
        {
            return a + b;

        }
        static double BeregnAreal(double radius)
        {
            return (radius * radius) * 3.1415;

        }

        static void Udskriv(string text)
        {
            Console.WriteLine(text);
        }
        static void Udskriv()
        {
            Console.WriteLine();
        }
    }
}
