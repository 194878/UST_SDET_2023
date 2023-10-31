
//driver
using Basic_Programs;


public delegate void del1( string mess);
class Program
{

    public static void Main(string[] args)
    {

        del1 dobj1 = DelegateExample.MethodA;
        dobj1("Hello  how are you");
    }
}




/*
GenEx<int> ga = new(new int[] { 1, 2, 3, 4 });
ga.Display();
*/

/*
GenEx<int> g1 = new GenEx<int>(10, 20);
Console.WriteLine(g1.Val1+"  "+g1.Val2);

GenEx<double> g2 = new GenEx<double>(10.097, 20.456);
Console.WriteLine(g2.Val1 + "  " + g2.Val2);


GenEx<string> g3= new GenEx<string>("HI", "Hello");
Console.WriteLine(g3.Val1 + "  " + g3.Val2);

GenEx<bool> g4 = new GenEx<bool>(true, false);
Console.WriteLine(g4.Val1 + "   " + g4.Val2);
*/






//using Basic_Programs.Exceptionmess;

//FileOperations fo=new FileOperations();
//fo.WriteData();
//fo.CreateFile();
//fo.CopyMoveFile();
//fo.ReadData();
//fo.DeleteFile();
//fo.FileProperties();


/*
ExceptionHandling excep = new ExceptionHandling(100, 107);

try
{
    excep.NumCheck();
   
}
catch(ArgumentException ex)

    {
    Console.WriteLine(ex.Message);
}
try
{
    excep.NumCheck1();

}
catch (ArgumentException ex)

{
    Console.WriteLine(ex.Message);
}




/*
try
{
    excep.Divide();
}
catch (ArithmeticException ex)
{

    Console.WriteLine(MyExceptions.excmesslist["Div 0"]);

}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(MyExceptions.excmesslist["IOR"]);
}
catch (Exception ex)
{
    Console.WriteLine(MyExceptions.excmesslist["UE"]);
}
finally
{
    Console.WriteLine("Done");
}
*/














/*
Console.WriteLine("1. TS 2. NTS");

switch (Convert.ToInt32(Console.ReadLine())) { 
    case 1:
        TeachingStaff ts=new TeachingStaff();
        ts.StaffId = 111;
        ts.Name = "Anu";
        ts.Dept = "CS";
        ts.Specializations = "OS DBMS";
        ts.Sem = 4;
        ts.DisplayTStaffDetails();
        break;

        case 2:
        NonTeachingStaff nts=new NonTeachingStaff();
        nts.StaffId = 991;
        nts.Name = "NTS1";
        nts.Dept = "CS";
        nts.Responsibilities = "Att, Sal";
        nts.Experience= 4;  
        nts.DisplayStaffDetails();
        nts.DisplayNTStaffDetails();
        break;


}

*/






/*
StudentGrade grade = new();
grade.RollNo = 11;
grade.StudentName = "Amu";
grade.City = "tvm";
grade.Mark1 = 12;
grade.Mark2 = 13;
grade.Mark3 = 14;

grade.DisplayStudentDetails();
Console.WriteLine("Total" +grade.CalculateTotal());
Console.WriteLine("Average" + grade.CalculateAverage()); 
Console.WriteLine("Grade"+grade.CalculateGrade());

/*StudentMarks marks = new();
marks.RollNo = 11;
marks.StudentName = "Amu";
marks.City = "tvm";
marks.Mark1 = 12;
marks.Mark2 = 13;
marks.Mark3 = 14;

marks.DisplayStudentDetails();
Console.WriteLine("Total" + marks.CalculateTotal());
    Console.WriteLine("Average" + marks.CalculateAverage());*/

//ArrayEx arrayEx = new ArrayEx();
//arrayEx.Ja();







/*
Employee employee = new(111, "AA", "IT", 10000);
Console.WriteLine("Emp id :{0}\n"+
   "Name : {1} \n"+ 
    "Dept : {2} \n"+
    "Basicpay : {3}\n"
    ,employee.Eid,
employee.Ename,
employee.Dept,
employee.Basicpay);
Console.WriteLine("Net Pay :{0}",employee.CalculateSalary());
*/








