using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesMod5
{
    public class Student
    {
        public int countStudent;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public int ZIP { get; set; }
        public string Country { get; set; }

        public Student(string first, string last, DateTime birthday) // string add1, string add2, string city, string stateprovince, int zip, string country)
        {
           FirstName = first;
           LastName = last;
           Birthday = birthday;
           //AddressLine1 = add1;
           //AddressLine2 = add2;
           //City = city;
           //StateProvince = stateprovince;
           //ZIP = zip;
           //Country = country;
        }

        public static int CountStudent()
        {
            Student[] student = new Student[3];
            int countStudent = student.Count(i => i != null);

            return countStudent;
        }
        
    }
}

