using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Assignment
{
    class Student
    {
        private string? studentname;
        private int[] marks = new int[3];
        private string? grade;

        public string? Studentname { get => studentname; set => studentname = value; }
        public int[] Marks { get => marks; set => marks = value; }
        public string? Grade { get => grade; set => grade = value; }

        public Student(string? studentname, int[] marks, string? grade)
        {
            Studentname = studentname;
            Marks = marks;
            Grade = grade;
        }
        public double CalculateAverage()
        {
            double average = marks.Average();
            return average;
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine("Student Name :" + studentname);
            Console.WriteLine("Grade:" + grade);
            int i = 1; int total = 0;

            foreach (var mark in marks)
            {
                Console.WriteLine("Marks : {0} {1}", i++, mark);
                total += mark;
            }
            Console.WriteLine("Total Mark: " + total);
            Console.WriteLine();
        }
        public string GetStudentSummary()
        {
            return $"{studentname} has {marks.Length}\nHighest Mark is {marks.Max()}\n Lowest Mark is{marks.Min()}";


        }













        /*
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
                }*/
    }
}

