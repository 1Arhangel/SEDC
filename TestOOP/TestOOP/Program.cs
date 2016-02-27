using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Human vasko = new Human();
            vasko.FirstName = "Vasko";
            vasko.LastName = "Stojkovski";

          

             

            Console.WriteLine(vasko.GetFullName());
        }
    }
}
