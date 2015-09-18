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

            var student1 = new Student("Hanna", "Gray", new DateTime(1985, 3, 15));
            var student2 = new Student("James", "Hunt", new DateTime(1974, 08, 24));
            var student3 = new Student("Elijah", "Jordan Wood", new DateTime(1981, 1, 28));

            Course course = new Course("Programming with C#");
            {
                course.AddStudent(student1);
                course.AddStudent(student2);
                course.AddStudent(student3);
            }

            Teacher teacher = new Teacher("Adam", "Smith", "math");

            course.AddTeacher(teacher);

            Degree degree = new Degree("Bachelor of Science", 8.5);

            degree.Course = course;

            UProgram uProgram = new UProgram("Information Technology", 120);

            uProgram.Degree = degree;

            Console.WriteLine("The {0} program contains the {1} degree", uProgram.Name, degree.Faculty);
            Console.WriteLine("The {0} degree contains the course {1}", degree.Faculty, course.Name);
            Console.WriteLine("The {0} course contains {1} student(s)", course.Name);

        }
    }
}
