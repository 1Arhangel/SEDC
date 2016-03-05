using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Shape
    {
        public virtual string Describe()
        {
            return "I am a shape";
        }

        public abstract int CalculateArea();
       
        


    }
}
