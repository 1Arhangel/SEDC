using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICalculable
    {
        int Perimeter { get; set; }

        int Area { get; set; }

        void CalculatePerimeter();

        void CalculateArea();
    }
}
