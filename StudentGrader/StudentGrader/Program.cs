using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrader
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How much students you want to put in the system?");
            int numberOfStudents = int.Parse(Console.ReadLine());
            Student[] _students = new Student[numberOfStudents];
            
            int _student = 0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("Please enter the student id");
                
                string Id = Console.ReadLine();

                bool scanning = SEDCMember.ScanIdCard(Id);
                bool isItReallyValid = SEDCMember.IsIdValid(Id);
                

                if (scanning && isItReallyValid)
                {
                    string scannedId = Id.Trim();
                }
                else
                {
                    Console.WriteLine("Please enter a valid student id");
                    string scannedId = Console.ReadLine();
                    Id = scannedId.Trim();
                }

                

                Console.WriteLine("Please enter the student first name");
                string firstName = Console.ReadLine();

                Console.WriteLine("Please enter the student last name");
                string lastName = Console.ReadLine();

                Student student = new Student(Id, firstName, lastName);
                
                

                Console.WriteLine("Please enter how much grades has the student so far");
                int numberOfGrades = int.Parse(Console.ReadLine());



                
                student.Grades = new int[numberOfGrades];

                for (int grade = 0; grade < numberOfGrades; grade++)
                {
                    Console.WriteLine("Please enter the grade now");

                    int theGrade = int.Parse(Console.ReadLine());

                    student.Grades[grade] = theGrade;
                }

                student._AverageGrade = student.AverageGrade();
                student._MaximumGrade = student.MaximumGrade();
                

                _students[_student] = student;
                
                _student+=1;

                



            }

            foreach (var student in _students)
            {
                Console.WriteLine(student.GetDetails()+", his average grade is "+Math.Round(student._AverageGrade,3)+" and his maximum grade is "+student._MaximumGrade);
            }

            

            Tuple<double, string>[] combo = new Tuple<double, string>[_students.Length];
            int index = 0;
            foreach (var student in _students)
            {
                combo[index] = new Tuple<double, string>(student._AverageGrade, student.GetDetails());
                index++;
            }

            var combos = new List<Tuple<double, string>> { };

            double highestValue = 0.00;
            
            string description = null;

            for (int i = 0; i < combo.Length; i++)
            {
                

                var item = combo[i].Item1;
                var desc = combo[i].Item2;

                if (item > highestValue)
                {
                    highestValue = item;
                    description = desc;
                }
                else if (item == highestValue)
                {
                    combos = new List<Tuple<double, string>> { combo[i] };
                    
                    foreach (var x in combos)
                    {
                        Console.WriteLine("The students with the best grades are "+combo[i].Item2+"and his average grade is "+combo[i].Item1);
                    }
                }
            }


            Console.WriteLine(description+" and he has the best average grade of "+Math.Round(highestValue, 2));
            
            Console.ReadLine();




        }
    }
}
