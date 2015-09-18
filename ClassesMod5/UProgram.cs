using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesMod5
{
    public class UProgram 
    {
        public string Name { get; set; }
        public int Credits { get; set; }
        public Degree Degree { get; set; }
       

        public UProgram(string name, int credits)
        {
            Name = name;
            Credits = credits;
        }
    }
}
