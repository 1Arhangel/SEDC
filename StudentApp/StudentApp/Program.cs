using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much students you want to enter in the system");
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("Please enter the student first name");
                string studentFirstName = Console.ReadLine();
                Console.WriteLine("Please enter the student last name");
                string studentLastName = Console.ReadLine();
                Console.WriteLine("Please enter the student ID");
                int studentId = int.Parse(Console.ReadLine());

                Console.WriteLine("How much projects the student has");
                int numberOfProjects = int.Parse(Console.ReadLine());
                List<Project> projects = new List<Project>();
                    for (int j = 0; j < numberOfProjects; j++)
                    {
                        Console.WriteLine("Please enter the project name");
                        string studentProjectName = Console.ReadLine();
                        Console.WriteLine("How much categories the project has");
                        int categories = int.Parse(Console.ReadLine());
                        List<Category> projectCategories = new List<Category>();
                        

                        for (int k = 0; k < categories; k++)
                        {
                            Console.WriteLine("Please enter the category name");
                            string categoryName = Console.ReadLine();
                            Console.WriteLine("Please enter how much points the student has in this category");
                            int categoryPoints = int.Parse(Console.ReadLine());
                            Category category = new Category(categoryName, categoryPoints);
                            projectCategories.Add(category);
                            
                        }

                        Project project = new Project(studentProjectName, projectCategories);
                        projects.Add(project);
                    }
                


                students.Add(new Student(studentId, studentFirstName, studentLastName,projects));

                

            }
            Console.ReadLine();
            Methods.StudentWithMostPoints(students);
        }

        
    }
}
