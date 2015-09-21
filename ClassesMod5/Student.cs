using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesMod5
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public int ZIP { get; set; }
        public string Country { get; set; }

        public Student(string first, string last, DateTime birthday) 
        {
           FirstName = first;
           LastName = last;
           Birthday = birthday;
           countStudentEnrolled = 0;
        }

        private static int countStudentEnrolled;         
    }
}

