using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool? A;
            char? B;
            //string? C;
            float? D;
            double? E;
            decimal? F;
            int? G;
            long? H;
            short? I;

            // exception cant convert null to string
            string text = null;
            var test = text.ToString();
            Console.ReadLine();

        }
    }
}
