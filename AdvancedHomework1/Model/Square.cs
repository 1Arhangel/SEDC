using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Square : ICalculable
    {
        public int Area
        {
            get; set;
        }

        public int Perimeter
        {
            get; set;
        }

        public int Side { get; set; }

        public void CalculateArea()
        {
            this.Area = this.Side * this.Side;
        }

        public void CalculatePerimeter()
        {
            this.Perimeter = 4 * this.Side;
        }
    }
}
