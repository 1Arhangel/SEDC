using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Shape
    {

        
        public string Name { get; set; }

        public static string PrintShapeName(Shape a, Shape b)
        {
            
            return a.Name +" "+ b.Name;
        }
    }

   
}
