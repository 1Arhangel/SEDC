using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Tasks
{
    class Program
    {
        static int[] DistinctNumbers(int[] param)
        {
            // distinct means ?
           return param.Distinct().ToArray();
        }

        static List<int> UnionNumbers()
        {
            int[] first = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] second = new int[] { 0, -1, -2, -3, -4, -5, -6, -7, -8, -9 };
            
            var unija = first.Union(second).ToList();
            return unija;

          
        }

        static List<int> Intersect()
        {
            int[] first = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] second = new int[] { 0, -1, -2, -3, -4, -5, -6, -7, -8, -9 };
            var intersect = first.Intersect(second).ToList();
            return intersect;
        }

        static void Main(string[] args)
        {

            List<Product> products = InitProducts();

            var namesOfProducts = products.Select(p => p.Name);

           

            int[] someNumbers = new int[] { 123, 213, 151, 45, 657, 765, 213,123 };

            var distinct = DistinctNumbers(someNumbers);

            var unija = UnionNumbers();

            var intersection = Intersect();

            var takenNumbers = someNumbers.Take(3);
            var skippedNumbers = someNumbers.Skip(3);
            Array.Sort(someNumbers);
            var descendingNumbers = someNumbers.OrderByDescending(number => number);

            Console.ReadLine();

        }
    
        
        static List<Product> InitProducts()
        {
            var products = new List<Product>();
            products.Add(new Product {
                Name = "Banana",
                Category = "Fruit",
                ID = 0,
                UnitPrice = 3,
                UnitsInStock = 10
            });
            products.Add(new Product
            {
                Name = "Apple",
                Category = "Fruit",
                ID = 1,
                UnitPrice = 2,
                UnitsInStock = 5
            });
            products.Add(new Product
            {
                Name = "Pepper",
                Category = "Vegetable",
                ID = 2,
                UnitPrice = 4,
                UnitsInStock = 13
            });
            products.Add(new Product
            {
                Name = "Potato",
                Category = "Vegetable",
                ID = 3,
                UnitPrice = 6,
                UnitsInStock = 4
            });
            products.Add(new Product
            {
                Name = "Tooth Paste",
                Category = "Higiene",
                ID = 4,
                UnitPrice = 6,
                UnitsInStock = 0
            });
            products.Add(new Product
            {
                Name = "Car Tire",
                Category = "Autos",
                ID = 5,
                UnitPrice = 12,
                UnitsInStock = 3
            });
            products.Add(new Product
            {
                Name = "Juice",
                Category = "Drinks",
                ID = 6,
                UnitPrice = 2,
                UnitsInStock = 5
            });
            products.Add(new Product
            {
                Name = "Soap",
                Category = "Higiene",
                ID = 7,
                UnitPrice = 3,
                UnitsInStock = 10
            });

            return products;
        }
    }
}
