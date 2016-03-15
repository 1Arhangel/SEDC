using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList hey = new ArrayList { 1, 2, 3.14, 4.4, "Vasko", "Stojkovski", };

            foreach (var item in hey)
            {
                Console.WriteLine("The item "+item+" is of type "+item.GetType());
            }

            Console.ReadLine();
        }
    }
}
