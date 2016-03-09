using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Initializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person0 = new Person { FirstName = "0 Vasko", LastName = "Stojkovski" };
            Person person1 = new Person { FirstName = "1 Vasko", LastName = "Stojkovski" };
            Person person2 = new Person { FirstName = "2 Vasko", LastName = "Stojkovski" };

            var aha = new { ime = "Vasko", prezime = "Stojkovski" };

            Person[] Persons = new Person[3] {person0, person1, person2};

            Person[] PersonsOnTheFly = new Person[] { new Person { FirstName = "Petar" }, new Person { FirstName = "Dejan" }, new Person { FirstName = "Vasko" } };

            foreach (Person person in Persons)
            {
                Console.WriteLine(person.FirstName +" "+person.LastName);
            }

            foreach (Person x in PersonsOnTheFly)
            {
                Console.WriteLine(x.FirstName);
            }

            Console.ReadLine();
        }
    }
}
