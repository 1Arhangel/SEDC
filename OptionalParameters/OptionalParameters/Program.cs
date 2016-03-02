using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Human;
namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Humans human = new Humans("Vasko", "Stojkovski");

            


            
            
            string welcomeMessage1 = "Welcome";
            string welcomeMessage2 = "Welcome again";

            Console.WriteLine(human.PrintWelcomeMessage("Hello","Hello again"));

            Console.WriteLine(human.PrintWelcomeMessage(welcomeMessage1, welcomeMessage2));

            Console.WriteLine(human.PrintWelcomeMessage());

            Console.WriteLine(human.PrintWelcomeMessage("Zdravo"));

            

            Console.WriteLine(human.IsFullNameLongerThanMaxLength());

            Console.ReadLine();
        }
    }
}
