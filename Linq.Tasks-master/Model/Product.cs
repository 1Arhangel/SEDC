using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        public int UnitsInStock { get; set; }
        public int UnitPrice { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
        public string Category { get; set; }
    }
}
