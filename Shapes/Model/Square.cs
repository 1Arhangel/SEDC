using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Square
    {
        public int Side { get; set; }

        public int CalculateArea()
        {
            return this.Side * this.Side;
        }

        public int CalculatePerimeter()
        {
            return 4 * this.Side;
        }

    }
}
