﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int xx = 1; xx < 11; xx++)
            {
                for (int yy = 1; yy < 11; yy++)

                {
                    string tal = (xx * yy).ToString();
                    if ((xx * yy) > 50)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(tal.PadLeft(4));


                }
                Console.WriteLine();
            }
        }
    }
}
