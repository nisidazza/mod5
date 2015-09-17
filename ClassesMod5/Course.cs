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

        public Teacher[] teacher;
        public Teacher[] Teacher
        {
            get
            {
                return teacher;
            }

            set
            {
                teacher = value;
            }
        }

        public Student[] student;
        public Student[] Student 
        {
            get
            {
                return student;
            }
            set
            {
                student = value;
            }
        }

        public Course(string name)
        {
            Name = name;
        }

       
    }
}
