using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static int smsMessages()
        {
            int messages;
            Console.WriteLine("Enter the credits on your mobile bill");
            float credits = float.Parse(Console.ReadLine());
            Console.WriteLine("How much is the cost of one message");
            float cost = float.Parse(Console.ReadLine());

            float tempMessages = credits / cost;
            messages = (int)tempMessages;
            //if (tempMessages < cost)
           // {
                //int messagess = (int)tempMessages;
                Console.WriteLine("You can write " + messages + " messages");
                Console.ReadLine();
            //}
            return messages;  
        }
        static void Main(string[] args)
        {
            Console.WriteLine(smsMessages());
            Console.ReadLine();
        }
    }
}
