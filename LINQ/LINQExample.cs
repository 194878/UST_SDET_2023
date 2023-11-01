using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQExample
    {

        public void Example1() { 
        
        List<string> courses = new List<string>();
            courses.Add("C Tutorials");
            courses.Add("C++ Tutorials");
            courses.Add("java Tutorials");
            courses.Add("web Tech");
            courses.Add("Cloud Tech");
            courses.Add("DbMs");
            courses.Add("UI exp");


            //var result= from  c in courses
            //where c.Equals("DbMs")
            // select c;
            //Console.WriteLine(result);


            // simple method syntax(lampda expression)
            //  var result = courses.Where(c => c.Equals("DbMs"));
            var result = courses.Where(c => c.Contains("Tech"));
            //var result = courses.Where(c => c.Distinct());


            foreach (var c in result)
            {
                Console.WriteLine(c);
            }

        }
        public void Example2()
        {

            List<Student> st = new List<Student>();
            st.Add(new Student(1,"aa","ece"));
            st.Add(new Student(2, "bb", "cse"));
            st.Add(new Student(3, "cc", "bsc"));
            st.Add(new Student(4, "dd", "bba"));
            st.Add(new Student(5, "ee", "mba"));
            st.Add(new Student(6, "ff", "mtech"));

            Student stud = (Student)st.FirstOrDefault(s => s.Id == 9);
            //foreach (var s in stud){

            if (stud != null)
            {
                Console.WriteLine("Student  :" + stud.Id + "   " + stud.Name + "  " + stud.Dept);
            }
            // }
            else {

                Console.WriteLine("student not found");
            }

            List<Student> stud1 = (List<Student>)st.FindAll(s => s.Name =="ff" || s.Name=="bb" );
            foreach (var s in stud1)
            {
                Console.WriteLine("Student  :" + s.Id + "   " + s.Name + "  " + s.Dept);

            }
            Console.WriteLine(">=5");
            List<Student> stud2 = (List<Student>)st.FindAll(s => s.Id>=5);
            foreach (var s in stud2)
            {
                Console.WriteLine("Student  :" + s.Id + "   " + s.Name + "  " + s.Dept);

            }

        }
    }
}
