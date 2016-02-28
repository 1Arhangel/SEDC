using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {

        private const string defaultName = " ";
        private const string defaultSurname = " ";
        private const int defaultAge = 0;
        private const bool defaultWearingGlasses = false;
        private const int[] defaultGrades = null;

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public bool WearingGlasses { get; set; }
        public int[] Grades { get; set; }

        
       public void printMe()
        {
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Surname: "+Surname);
            Console.WriteLine("Age: "+Age);
            Console.WriteLine("Wearing glasses: "+WearingGlasses);

            if (Grades == null)

            {
                Console.WriteLine("There are no grades to print \n");
            }

            else

            {
                for (int i = 0; i < Grades.Length; i++)
                {
                    int ii = i + 1;

                    Console.WriteLine("Grade " + ii + " is " + Grades[i]);
                }
                Console.WriteLine();
            }
        }

        public void ResetValues(Student student)
        {
            student.Name = defaultName;
            student.Surname = defaultSurname;
            student.Age = defaultAge;
            student.WearingGlasses = defaultWearingGlasses;
            student.Grades = defaultGrades;
            student.printMe();
        }
    }
}
