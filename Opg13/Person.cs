using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg13
{
   public class Person
    {
        
        public String Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string FuldtNavn()
        {
            return $"{Fornavn} {Efternavn}";
        }
    }
}
