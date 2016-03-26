using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class Methods
    {
        public static void PrintStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine("The student full name is "+student.FirstName+" "+student.LastName);
            }
        }

        public static void StudentWithMostPoints(List<Student> students)
        {
            //  var bestStudent = students.Select(z=>z).SelectMany(x => x.Project);
            var bestStudent = students.OrderByDescending(x => x.Project.Select(y => y.TotalPoints).Sum());
            var bestStudent1 = bestStudent.First();
        }

        public static double AveragePoints (List<Student> students)
        {
            var averagePoints = students.Select(x => x.Project.Select(y => y.TotalPoints).Sum()).Average();

            return averagePoints;

            
        }
    }
}
