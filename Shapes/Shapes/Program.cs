using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();

            Console.WriteLine("Enter the square side");
            square.Side = int.Parse(Console.ReadLine());
            

            Console.WriteLine("The Area is " +square.CalculateArea());

            Console.WriteLine("The Perimeter is "+square.CalculatePerimeter());
        }
    }
}
