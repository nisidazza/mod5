using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesMod5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] student = new Student[3];
            student[0] = new Student("Hanna", "Grey", 12 / 05 / 1985, "Cable St. 3", "Lower St. 4", "Los Angeles", "California", 90003, "USA");
            var student2 = new Student();
            var student3 = new Student();

            Console.WriteLine(Student.countEnrolledStudent);
        }
    }
}
