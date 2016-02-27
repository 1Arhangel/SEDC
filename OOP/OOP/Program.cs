using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car();
            Ford.Color = "Gray";
            Ford.NumberOfWheels = 4;
            Ford.Model = "Focus";

            string fullCar = Ford.PrintFullCar();

            Console.WriteLine(fullCar);

            Console.WriteLine(Ford.PrintFullCar("Black", "Porsche"));

           
            //Hand leftHand = new Hand();
            //leftHand.NumberOfFingers = 5;
            //leftHand.Orientation = "Left";
            //leftHand.SkinColor = "White";
            //leftHand.DoesItHaveNails = true;
            //leftHand.Size = 20;

            //Console.WriteLine(leftHand.NumberOfFingers);

            //Hand rightHand = new Hand();
            //rightHand.NumberOfFingers = 4;
            //rightHand.Orientation = "Left";
            //rightHand.SkinColor = "White";
            //rightHand.DoesItHaveNails = true;
            //rightHand.Size = 20;

            //Console.WriteLine(rightHand.NumberOfFingers);
        }
    }
}
