using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        public static void PrintArrayList(ArrayList a)
        {
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

        }

        public static void PrintHashtable(Hashtable a)
        {
            foreach (DictionaryEntry item in a)
            {
                Console.WriteLine(item.Key +" "+ item.Value);
            }
        }

        public static void PrintStack (Stack a)
        {
            foreach (Object item in a)
            {
                Console.WriteLine(item);
                
            }

            Console.WriteLine();
        }

        public static void PrintQueue (Queue a)
        {
            foreach (var item in a) 

            {
                Console.WriteLine(item);
            }
        }

        public static void PrintDictionary(Dictionary<int,string> param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
        static void Main(string[] args)
        {
            //ArrayList somethingNew = new ArrayList { 10, 10, "Vasko", "Stojkovski" };
            //PrintArrayList(somethingNew);

            //Hashtable someHashtable = new Hashtable();
            //someHashtable.Add(1, "a");
            //someHashtable.Add(2, "a");
            //someHashtable.Add(3, "Vasko");
            //someHashtable.Add(4, "Stojkovski");

            //PrintHashtable(someHashtable);


            //Stack someStack = new Stack();

            //someStack.Push(1);
            //someStack.Push(1);
            //someStack.Push("Vasko");
            //someStack.Push("Stojkovski");

            //PrintStack(someStack);

            //Queue someQueue = new Queue();

            //someQueue.Enqueue("Queue 1");
            //someQueue.Enqueue(" Queue 1");
            //someQueue.Enqueue("  Queue  Vasko");
            //someQueue.Enqueue("Queue Stojkovski");

            //PrintQueue(someQueue);

            //List<object> someNewList = new List<object> { };
            //someNewList.Add("Vasko");
            //someNewList.Add("Stojkovski");
            //someNewList.Add(1);
            //someNewList.Add(2);


            //Dictionary<int, string> someDictionary = new Dictionary<int, string> { };
            //someDictionary.Add(1, "Vasko");
            //someDictionary.Add(2, "Stojkovski");
            //if (!someDictionary.ContainsKey(3))
            //    someDictionary.Add(3, "Vasko Stojkovski");
            //var keys = someDictionary.Keys;
            //var values = someDictionary.Values;
            //var count = someDictionary.Count;
            //PrintDictionary(someDictionary);

            int a = 0;
            int b = 4;
            
            try
            {
                int c = b / a;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("You tried to divide with 0"); 
            }

            string[] array = new string[1];
            array[0] = "Vasko";
            try
            {
                array[1] = "Stojkovski";
                
            }
            catch (Exception)
            {
                

                Console.WriteLine("The array length is 1");
            }
            
            Console.ReadLine();
        }
    }
}
