using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionBetweenTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int Number = 10;
            //string aNumber = Number.ToString();

            //double aDouble = 10.101;

            //string Double = aDouble.ToString();
            //Console.WriteLine(Double);


            //string text = "vasko";
            //int result;
            //bool canConvert = int.TryParse(text, out result);

            //// canConvert == true
            //if (canConvert)
            //{
            //    Console.WriteLine(result);

            //}
            //else
            //{
            //    Console.WriteLine("Cant convert to int");
            //}
            


            //string brojce = "2.33";
            //double.Parse(brojce);



            string[] Strings = { "A", "Z", "CcCcCc", "ZA", "ZZZ" };

            //for (int i = 0; i < Strings.Length; i++)
            //{
            //    Console.WriteLine(Strings[i]);
            //}

            int[] Numbers = { 100, 1000, 2 };

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //foreach (var item in Strings)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in Numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Sort(Strings);
            //Array.Sort(Numbers);

            //foreach (var item in Strings)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in Numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //var strLen = Strings.Length;
            //var numLen = Numbers.Length;

            //var firstString = Strings.First();
            //Console.WriteLine(firstString);

            //var firstNumber = Numbers.First();
            //Console.WriteLine(firstNumber);

            //var LastNumber = Numbers.Last();
            int[] praznaNiza = {1,21,3 };

            var Max = Strings.Max();
            var Nax = Numbers.Max();

            var Sum = Numbers.Sum()+praznaNiza.Sum();

            Console.WriteLine(Nax);
            Console.WriteLine(Max);
            Console.WriteLine(Sum);

            var temp = praznaNiza.FirstOrDefault();
            

            Console.ReadLine();
            
        }
    }
}
