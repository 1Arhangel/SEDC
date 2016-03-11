using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Interfaces;

namespace Model
{
    public class Human:IPrintable, ICalculable, IThird
    {
        public string FullName { get; set; }
      

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintFullName()
        {
            Console.WriteLine(FirstName +" "+ LastName);
        }

        public int NameLen()
        {
            return FirstName.Length;
        }
        
        public Human(string firstName, string LastName)
        {
            this.FirstName = firstName;
            this.LastName = LastName;
        }
     
    }
}
