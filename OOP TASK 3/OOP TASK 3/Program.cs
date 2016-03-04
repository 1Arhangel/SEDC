using Inheritance;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASK_3
{
    class Program
    {
        static void Main(string[] args)

        {
            //Shape shape = new Shape();
            //shape.Name = "Square";

            //Shape shape2 = new Shape();
            //shape2.Name = "Rectangle";

            //Console.WriteLine(Shape.PrintShapeName(shape,shape2));


            //Console.WriteLine(Calculator.Sum(7, 8));
            //Console.WriteLine(Calculator.SquareRoot(16));
            //Console.ReadLine();

            //Square square = new Square();

            //square.Name = "Square";
            //square.SideLength = 20.00;

            //Rectangle rectangle = new Rectangle();

            //rectangle.Name = "Rectangle";
            //rectangle.SideA = 10.00;
            //rectangle.SideB = 15.00;


            //Shape shape = new Shape();
            //shape.Name = "Shape";

            Baker baker = new Baker();

            baker.Name = "Vasko";
            baker.LastName = "Stojkovski";

            Seller seller = new Seller();
            
            seller.Name = "Orce";
            seller.LastName = "Petreski";

            Customer customer1 = new Customer();
            Customer customer2 = new Customer();

            customer1.Name = "Dejan";
            customer1.LastName = "Keroski";

            customer2.Name = "Ivan";
            customer2.LastName = "Prezime";

            Product product1 = new Product();
            product1.Name = "Pizza";

            Product product2 = new Product();
            product2.Name = "Burek";

            //Console.WriteLine(baker.Sell(baker, customer1, product1));

            // Console.WriteLine(seller.Sell(seller, customer2, product2));

            Console.WriteLine(baker.Sell(baker.Name, customer1.Name + customer1.LastName, product1.Name));
            Console.WriteLine(seller.Sell(seller.Name, customer2.Name + customer2.LastName, product2.Name));
            Console.ReadLine();
            


            
            
        }
    }
}
