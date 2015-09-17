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

        public static int countEnrolledStudent = 0;

        public Student()
        {
            countEnrolledStudent++;
        }

        public static int GetEnrolledStudent()
        {
            return countEnrolledStudent;
        }

        public Student(string first, string last, DateTime birthday, string add1, string add2, string city, string stateprovince, int zip, string country)
        {
            this.FirstName = first;
            this.LastName = last;
            this.Birthday = birthday;
            this.AddressLine1 = add1;
            this.AddressLine2 = add2;
            this.City = city;
            this.StateProvince = stateprovince;
            this.ZIP = zip;
            this.Country = country;
        }
        
        
    }
}

