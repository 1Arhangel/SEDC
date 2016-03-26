using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Project
    {
        public int TotalPoints { get; set; }
        
        public string Name { get; set; }

        List<Category> Categories { get; set; }

        public Project(string name, List<Category> categories)
        {
            this.Name = name;
            this.Categories = categories;
            this.TotalPoints = totalPoints(categories);
        }
        public int totalPoints (List<Category> categories)
        {
            var points = categories.Select(x => x.Points).ToList();
            return points.Sum();
        }
    }
}
