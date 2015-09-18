using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesMod5
{
    public class Course
    {
    
        public string _name;
        public string Name { get; set; }
        Student[] students = new Student[3];
        Teacher[] teachers = new Teacher[3];
        private int numberOfStudents;
        private int numberOfTeachers;


        public Course(string _name)
        {
            Name = _name;
        }

        public void AddStudent(Student student)
        { 
            students[numberOfStudents] = students[3];
            numberOfStudents++;
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers[numberOfTeachers] = teachers[1];
            numberOfTeachers++;
        }

        

       
    }
}
