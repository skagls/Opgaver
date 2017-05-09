using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg14
{
    public class Terning
    {
        private static System.Random rnd;
        private int værdi;
        public int Værdi
        { get
            { Console.WriteLine("Terning aflæses som" + this.værdi);
                return this.værdi;
            }
            set
            {
                if (value < 0 || value > 6)
                    value = 1;
                Console.WriteLine("Terning toldeles" + value);
                this.værdi = value;
                
            }
        }
        public void Skriv()
        { Console.WriteLine("[" +this.Værdi+ "]");
        }
        public void Ryst()
        { this.Værdi = rnd.Next(1, 7);
        }
        public Terning ()
        {
            this.Ryst();
        }
        public Terning (int værdi)
        {
            this.Værdi = værdi;
        }
        static Terning()
        {
            rnd = new Random();
        }
    
    }
}
