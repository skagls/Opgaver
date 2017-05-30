using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg19
{
    class Program : Person
    {
        static void Main(string[] args)
        {
            //public int Id { get; set; }
            //public string Navn { get; set; }


            List<Person> lst1 = new List<Person>();
            lst1.Add(new Person() { Id = 1, Navn = "M" });
            lst1.Add(new Person() { Id = 2, Navn = "T" });
            lst1.Add(new Person() { Id = 3, Navn = "P" });
            foreach (var item in lst1)
            {
                Console.WriteLine(item.Navn);
            }
            Dictionary<int, Person> Lst2 = new Dictionary<int, Person>();
            Lst2.Add(1,new Person() { Id = 1, Navn = "M" });
            Lst2.Add(2, new Person() { Id = 2, Navn = "T" });
            Lst2.Add(3, new Person() { Id = 3, Navn = "P" });
            var p = Lst2[1];
            Console.WriteLine(p.Navn);


        }
    }
}
