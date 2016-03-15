using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Rectangle : ICalculable
    {
        public int Area
        {
            get; set;

        }

        public int Perimeter
        {
            get; set;
        }

        
        public int Width { get; set; }

        public int Length { get; set; }

        public void CalculateArea()
        {
            this.Area = this.Width * this.Length;
        }

        public void CalculatePerimeter()
        {
            this.Perimeter = (this.Length + this.Width) * 2;
        }
    }
}
