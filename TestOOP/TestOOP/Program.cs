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
        static int BiggerPerimeter(Rectangle rectangle, Square square)
        {
            if (square.CalculatePerimeter() > rectangle.CalculatePerimeter())
            {
                return square.CalculatePerimeter();
            }

            else
            {
                return rectangle.CalculatePerimeter();
            }
        }

        static void PrintArea(Rectangle rectangle, int n)

        {
            for (int i=0; i<n; i++)
            {
               Console.WriteLine("The area of the rectangle is "+rectangle.CalculateArea());
            }
        }

    


        static void Main(string[] args)
        {
            Square square = new Square();


            Console.WriteLine("Enter the square side ");
            square.Side = int.Parse(Console.ReadLine());

            Console.WriteLine("The Area is " + square.CalculateArea());
            Console.WriteLine("The Perimeter is " + square.CalculatePerimeter());

            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Enter the rectangle width ");
            rectangle.Width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the rectangle length ");
            rectangle.Length = int.Parse(Console.ReadLine());

            Console.WriteLine("The area of the rectangle is " + rectangle.CalculateArea());
            Console.WriteLine("The perimeter of the rectangle is " + rectangle.CalculatePerimeter());
            Console.WriteLine("The diagonal of the rectangle is " + rectangle.CalculateDiagonal());
            Console.WriteLine("The longer side of the rectangle is " + rectangle.LongerSide());

            Console.WriteLine("The bigger perimeter is " + BiggerPerimeter(rectangle, square));

            Console.WriteLine("Please enter how many times you want the area of the rectangle you want to be written ");
            int n = int.Parse(Console.ReadLine());

            PrintArea(rectangle, n);

            
        }
    }
}
