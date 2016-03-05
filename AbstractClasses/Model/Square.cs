using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Square:Shape
    {
        override public string Describe()
        {
            return "I am a square";
        }

        override public int CalculateArea()
        {
            return 8;
        }
    }
}
