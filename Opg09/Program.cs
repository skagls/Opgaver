using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg09
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1;
            t1 = new Terning();
            Console.WriteLine(t1.Værdi);
            Terning t2;
            t2 = new Terning(2);
            Console.WriteLine(t2.Værdi);
            t2 = t1;
            Console.WriteLine(t1.Værdi);
            Console.WriteLine(t2.Værdi);
            t1.Værdi = 1;
            Console.WriteLine(t1.Værdi);
            Console.WriteLine(t2.Værdi);
            t2.Værdi = 6;
            Console.WriteLine(t1.Værdi);
            Console.WriteLine(t2.Værdi);
            
        }
    }
    class Terning
    {
        public int Værdi;
        public Terning ()
        {
            this.Værdi = new Random().Next(1, 7);
        }
        public Terning (int Værdi)
        {
            this.Værdi = Værdi;
        }
        
    }
}
