using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Rectangle
    {
        public int Width { get; set; }
        public int Length { get; set; }

        public int CalculateArea()
        {
            return this.Width * this.Length;
        }

        public int CalculatePerimeter()
        {
            return (this.Length + this.Width) * 2;
        }

        public double CalculateDiagonal()
        {
            return Math.Sqrt(this.Width * this.Width + this.Length * this.Length);
        }

        public int LongerSide()
        {
            if (this.Length > this.Width)

            {
                return this.Length;
            }

            else

            {
                return this.Width;
            }

        }





    }
}

