using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public sealed class Student:SEDCMember
    {
        public Student(string Id, string FirstName, string LastName)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;

        }
        public int _MaximumGrade { get; set; }
        public double _AverageGrade { get; set; }

        public int[] Grades { get; set; }

        public int MaximumGrade()
        {
            int Max = Grades.Max();
            return Max;
        }

        public double AverageGrade()
        {
            return Grades.Average();
        }

        
        public override string GetDetails()
        {
            return "Student full name is "+this.FirstName +" "+ this.LastName +", his ID is "+ this.Id;   
        }

        
    }
}
