using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FunWithVariableScope
{
    class Program
    {
        public static void Method1()
        {
            string result = "Local";
            Console.WriteLine(result);
        }
        

        public static void Method2(string result)
        {
            Console.WriteLine(result);
        }

        string result;
        public static void Method3(string result)
        {
            result = "This is still a global variable";
        }
        static dynamic Test()
        {
            return 1;
        }
        static dynamic TestHuman()
        {
            Human human = new Human { FirstName = "Orce", LastName = "Petreski" };
            return human;
        }
        static void FunWithReflection()
        {
            int aNumber = 9;
            string aValue = aNumber.GetType().Name;
            Human human = new Human();
            human.GetType().GetProperty("FirstName").SetValue(human,"Vasko");

            Human human2 = new Human();
            human2.FirstName = "Vasko";
            human2.LastName = "Stojkovski";

            foreach (var item in human2.GetType().GetProperties())
            {
                Console.WriteLine(item.Name +" "+ item.GetValue(human2));
            }

            Dictionary<string, object> Properties = new Dictionary<string, object>();
            Properties.Add("FirstName", "Orce");
            Properties.Add("LastName", "Petreski");

            Human orce = new Human();

            foreach (var item in Properties)
            {
                orce.GetType().GetProperty(item.Key).SetValue(orce, item.Value);
            }

            
            Console.WriteLine(orce.FirstName +" "+orce.LastName);
            
        }

        static void FunWithThreads()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerAsync();
            
            Console.WriteLine("Started");
            //anonymous

            worker.DoWork += (obj, e) => { };
        }

        private static void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < int.MaxValue; i++)
            {
                //Console.WriteLine(i);
            }
            Console.WriteLine("Work Completed!");
        }

        

            
        static void Main(string[] args)
        {
            FunWithThreads();
            string result = "This is a global scope variable";

            Method1();
            Method2(result);
            Method3(result);
            

            Human human = new Human { FirstName = "Vasko", LastName = "Stojkovski" };
            Console.WriteLine(human.FullName);

            
            dynamic temp = 1;
            
            temp = "temp";

            temp = Test();

            temp = TestHuman();

            

            Console.WriteLine(temp.FullName);

            FunWithReflection();
            
            Console.ReadLine();

        }
    }
}
