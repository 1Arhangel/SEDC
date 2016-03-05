using Model;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Square square = new Square();

            

            Console.WriteLine(rectangle.Describe());
            Console.WriteLine(square.Describe());

            Person person = new Person();
            person.LastName = "Vasko";
            person.Name = "Stojkovski";
            Console.ReadLine();
        }
    }
}
