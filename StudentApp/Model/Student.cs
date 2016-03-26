using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Project> Project { get; set; }

        public Student(int Id, string FirstName, string LastName, List<Project> Projects)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Project = Projects;
        }
    }
}
