using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Rectangle:Shape
    {
        override public string Describe()
        {
            return "I am a Rectangle";
        }

        public override int CalculateArea()
        {
            return 4;
        }
    }
}
