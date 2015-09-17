using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesMod5
{
    public class Course
    {
        public string Subject { get; set; }
        public string AcademicTerms { get; set; }
        public double Grade { get; set; }
        public Teacher[] Teacher { get; set; }
        public Student[] Student { get; set; }

        public Course(string subject, string academicterms, double grade)
        {
            Subject = subject;
            AcademicTerms = academicterms;
            Grade = grade;
        }

        //Student[] Student = new Student [3];
        //Teacher[] Teacher = new Teacher[3];
    }
}
