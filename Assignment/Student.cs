using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
     class Student
    {
        public string? studentname;
        int g1, g2, g3;

        public Student(string? studentname, int g1, int g2, int g3)
        {
            this.studentname = studentname;
            this.g1 = g1;
            this.g2 = g2;
            this.g3 = g3;
        }
        public double CalculateAverage()
        {
            double average = (g1 + g2 + g3)/3;
            return average;
        }
    }
}
