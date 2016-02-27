using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Car
    {
        public int NumberOfWheels { get; set; }

        public string Color { get; set; }

        public string Model { get; set; }

        public string PrintFullCar()
        {
            return this.Model + " " + this.Color + " ";
        }

        public string PrintFullCar(string Color, string Model)
        {
            return Color + " " + Model;
        }


    }
}
