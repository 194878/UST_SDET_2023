// See https://aka.ms/new-console-template for more information
using Assignment;
using System.Runtime.Serialization;
using System.Security.Cryptography;


Student[] student = new Student[3]
    { new Student("ANU",new int[] {20,25,27},"C"),
      new Student("MANU", new int[] { 60, 65, 67 }, "B"),
      new Student("ANJU", new int[] { 90, 95, 97 }, "A")
    };


foreach (Student s in student)
{
 
    s.DisplayStudentDetails();
    Console.WriteLine("Average is"+s.CalculateAverage());
    Console.WriteLine(s.GetStudentSummary());

}




/*

Product P1=new Product("sugar", 14.5, 30);
Product P2= new Product("salt", 4.5, 50);
Product P3 = new Product("wheat", 23.5, 40);
Product[] products = { P1, P2, P3 };

foreach (Product product in products)
{
    product.DisplayProductDetails();
    Console.WriteLine("Total Value:" + product.ProductValue());
    Console.WriteLine();
}
*/