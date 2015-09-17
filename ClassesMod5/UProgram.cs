using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesMod5
{
    public class UProgram 
    {
        public int Credits { get; set; }
        public Degree Degree { get; set; }
        public string Duration { get; set; }

        public UProgram(int credits, string duration)
        {
            Credits = credits;
            Duration = duration;
        }
    }
}
