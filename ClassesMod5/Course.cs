using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesMod5
{
    public class Course
    {
        //public string Subject { get; set; }
        //public string AcademicTerms { get; set; }
        //public double Grade { get; set; }

        public string name;
        public string Name { get; set; }

        public Course(string name)
        {
            Name = name;
        }

        Student[] student = new Student[3];

        public void AddStudent(Student student);

        Teacher[] teacher = new Teacher[3];

        public void AddTeacher(Teacher teacher);

        
    

    }
}
