using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg12
{
    class Person
    {
        public string Fornavn { get; set; }
        private string efternavn;

        public string Efternavn
        {
            get { return efternavn; }
            set {
                if (value.Length < 3)

                {
                    efternavn = " ";
                }
                efternavn = value;
            }
        }

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;

        }



    }
}
