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
            Student vasko = new Student();
            vasko.Name = "Vasko";
            vasko.Surname = "Stojkovski";
            vasko.WearingGlasses = false;
            vasko.Age = 28;
            vasko.Grades = new int[5] { 6, 7, 8, 9, 10 };

            vasko.printMe();
            vasko.ResetValues(vasko);
        }
    }
}
