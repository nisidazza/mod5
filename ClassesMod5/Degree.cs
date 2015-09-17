using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesMod5
{
    public class Degree
    {
        public Course Course { get; set; }
        public string Faculty { get; set; }
        public double FinalGrade { get; set; }

        public Degree(string faculty, double finalgrade)
        {
            Faculty = faculty;
            FinalGrade = finalgrade;
        }
    }
}
