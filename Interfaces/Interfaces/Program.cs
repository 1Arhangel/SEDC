using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Interfaces;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrintable printMe = new Human("Vasko", "Stojkovski");
            printMe.PrintFullName();

            ICalculable calcMe = new Human("Vasko", "Stojkovski");
            Console.WriteLine(calcMe.NameLen());

            Console.ReadLine();

            
            
        }
    }
}
