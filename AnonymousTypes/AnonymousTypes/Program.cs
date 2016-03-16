using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var teacher = new { Name = "Orce", Surname = "Petreski", Years = 38 };
            
            Console.WriteLine(teacher.GetType());
            Console.ReadLine();

            var anon = new [] { new { Name = "Orce"}, new {Name = "Vasko" } };
        }
    }
}
