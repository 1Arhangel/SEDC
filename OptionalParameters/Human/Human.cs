using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    public class Humans
    {
        
        public Humans(string param1, string param2)
        {
            this.FirstName = param1;
            this.LastName = param2;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        
        public bool IsFullNameLongerThanMaxLength(int maxLength=0)
        {
            if (maxLength > this.FirstName.Length)

                return true;
            else
                return false;
        }

        public string PrintWelcomeMessage(string welcomeMessage1="Pozdrav", string welcomeMessage2="Pozdrav pak")
        {
            return welcomeMessage1 + " " + this.FirstName + " " + this.LastName + " " +welcomeMessage2;
        }


    }
}
