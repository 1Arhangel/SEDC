using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Category
    {
        public string Name { get; set; }

        

        public int Points { get; set; }

        public Category(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }
    }
}
