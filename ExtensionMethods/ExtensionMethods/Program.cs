using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Vasko";
            Console.WriteLine(Name.WordCount());

            StringExtensions.WordCount("432");

            Console.ReadLine();
        }
    }
}
