using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Status status = Status.Active;

            //if (status == Status.Active)
            //{
            //    Console.WriteLine("WoW");   
            //}
            Console.WriteLine("1.Input Money");
            Console.WriteLine("2.Withdraw Money");
            Console.WriteLine("3.Balance Money");
            Console.WriteLine("4.Exit Money");
            string text = Console.ReadLine();
            int option = int.Parse(text);

            switch (option)
            {
                case (int)Status.InputMoney:
                    break;
                case (int)Status.WithdrawMoney:
                    break;
                case (int)Status.Balance:
                    break;
                case (int)Status.Exit:
                    break;
                default:
                    break;
            }

            
            Console.ReadLine();


        }
    }
}
