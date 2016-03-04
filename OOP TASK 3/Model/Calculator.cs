using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class Calculator
    {
        static Calculator() { }
        public static int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static double SquareRoot(double number)
        {
            return Math.Sqrt(number);
        }
    }
}
