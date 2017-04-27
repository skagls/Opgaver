using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg01HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("Indtast Navn");
            String navn = Console.ReadLine();
            String stortNavn = navn.ToUpper();
            Console.WriteLine("Velkommen " +  stortNavn);
            Console.WriteLine("Tryk en tast for at fortsætte");
            Console.ReadKey();
            
      

        }
    }
}
