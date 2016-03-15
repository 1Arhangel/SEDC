using Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3

{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICalculable> ListOfICalculables = new List<ICalculable> { };

            Square square = new Square { Side = 8 };

            Rectangle rectangle = new Rectangle { Width = 4, Length = 8 };

            ListOfICalculables.Add(square);
            ListOfICalculables.Add(rectangle);

            for (int i = 0; i < ListOfICalculables.Count; i++)  
            {
                var item = ListOfICalculables[i];
                item.CalculateArea();
                item.CalculatePerimeter();
                Console.WriteLine("For "+item.ToString()+" the area is "+item.Area + " and the perimeter is " + item.Perimeter);
            }

            Console.ReadLine();
            
        }
    }
}
