using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg18
{
    class Hund : IComparable
    { 
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(object obj)
        {
            //throw new NotImplementedException();

            Hund h = obj as Hund;
        if (h.Alder > this.Alder)
                return -1;
            if (h.Alder < this.Alder)
                return -1;
            return 0; 
        }
    
        
        
    }
}
