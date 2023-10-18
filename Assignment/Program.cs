// See https://aka.ms/new-console-template for more information
using Assignment;

Student student = new Student("Manu", 40, 30, 47);
Console.WriteLine("Average grade of"+student.studentname+""+"is"+""+student.CalculateAverage());
Student student1 = new Student("Anu", 47, 32, 27);
Console.WriteLine("Average grade of" + student1.studentname + "" + "is" + "" + student1.CalculateAverage());
Student student2 = new Student("Manu", 20, 30, 37);
Console.WriteLine("Average grade of" + student2.studentname + "" + "is" + "" + student2.CalculateAverage());



