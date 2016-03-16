using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product;
namespace LINQtoObjects
{
    class Program
    {
        public static List<Productz> ProductsOnStock(List<Productz> productz)
        {
            List<Productz> listOfProducts = new List<Productz> {
                new Productz { UnitsInStock = 4,UnitPrice = 6000.00,Name="Keyboard",Id =4,Category = "Gaming"},
                new Productz { UnitsInStock = 2,UnitPrice = 7500.00,Name="Mouse",Id =44,Category = "Gaming"},
                new Productz { UnitsInStock = 6,UnitPrice = 12500.00,Name="Monitor",Id =5,Category = "Monitors"},
            };

            return productz = listOfProducts.Where(x => x.UnitPrice > 3000.00 & x.UnitsInStock > 0).ToList();
        }

        static void Main(string[] args)
        {
            List<Human> humans = new List<Human> {
                new Human { FirstName = "Vasko", LastName = "Stojkovski" },
                new Human { FirstName = "Orce", LastName = "Petreski" },
                new Human { FirstName = "Darko", LastName = "Kotoski" },
                new Human { FirstName = "Orce", LastName = "Stevkovski" }

            };

            Human theFirstHuman = humans.First<Human>();
            Human theLastHuman = humans.Last<Human>();

            Console.WriteLine(theFirstHuman.FirstName+" "+theFirstHuman.LastName);
            Console.WriteLine(theLastHuman.FirstName + " " + theLastHuman.LastName);

            // x kade x.FirstName == "Orce" go stavame vo listata orces
            var orces = humans.Where(x => x.FirstName == "Orce").ToList();
            var stefkovskis = humans.Where(y => y.LastName == "Stevkovski").ToArray();
            
            //foreach (var item in orces)
            //{
            //    Console.WriteLine(item.FirstName);
            //}

            List<int> listOfIntegers = new List<int>();
            
            listOfIntegers.Add(1);
            listOfIntegers.Add(2153);
            listOfIntegers.Add(362);
            listOfIntegers.Add(33214);
            listOfIntegers.Add(325);
            listOfIntegers.Add(4356);
            
            
            listOfIntegers.Sort();
            int sum = listOfIntegers.Sum();
            int min = listOfIntegers.Min();
            int max = listOfIntegers.Max();


            int[] arrayOfInt = new int[] { -2143, 32, 56, 7, 2, 1, 9, 0, -32 };
            // lambda expression
            int[] sortedArray = arrayOfInt.Where(x => x < 5).ToArray();
            //query expression
            var lessThan5numbers = from n in arrayOfInt
                                   where n < 5
                                   select n;


            List<Productz> priceIsMoreThan300andUnitsInStockIsMoreThan0 = new List<Productz>();

            priceIsMoreThan300andUnitsInStockIsMoreThan0 = ProductsOnStock(priceIsMoreThan300andUnitsInStockIsMoreThan0);
            Console.ReadLine();


            
        }

        
    }
}
