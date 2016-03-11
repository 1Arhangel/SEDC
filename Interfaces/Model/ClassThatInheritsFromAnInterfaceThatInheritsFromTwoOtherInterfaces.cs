using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ClassThatInheritsFromAnInterfaceThatInheritsFromTwoOtherInterfaces:IThird
    {
        public int NameLen()
        {
            return 65;
        }

        public string FullName { get; set; }

        public void PrintFullName()
        {
            
        }
    }
}
