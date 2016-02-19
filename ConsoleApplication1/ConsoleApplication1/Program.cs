using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //static int concatStrangeThings()

        //{
        //    int a = 6;
        //    string b = "12";
        //    int c = a + int.Parse(b);
        //    Console.WriteLine(c);
        //    Console.ReadLine();
        //    return c;
        //}
        static int theApplesAndTheBaskets()
        {
            Console.WriteLine("Enter the number of apples on the tree");
            int apples = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how much apples can you put in one basket");
            int basket = int.Parse(Console.ReadLine());
            int baskets;
            int tempBaskets = apples % basket;

            if (tempBaskets == 0)

            {

                baskets = apples / basket;
                Console.WriteLine(baskets);
            }
            
            else if (tempBaskets >= 1) 
            
            {
                baskets = apples / basket + 1;
                Console.WriteLine(baskets);
            }
            
            
            Console.ReadLine();
            return tempBaskets;
        }

        static void Main(string[] args)

        {
           Console.WriteLine(theApplesAndTheBaskets());
        }
    }
}
