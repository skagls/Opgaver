using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Opg20_Brug_af_Using
{
    class Program
    {
        static void Main(string[] args)

        {
            using (StreamReader stream = System.IO.File.OpenText("dyrenavn.txt"))
            {
                while (stream.Peek()!=-1)
                {
                    var l = stream.ReadLine();
                    Console.WriteLine(l.ToUpper());
                }
            }

        }
    }
}
