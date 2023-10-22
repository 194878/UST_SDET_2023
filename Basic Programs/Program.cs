
//driver
using Basic_Programs;
Doctor doc=new Doctor();
doc.AddNewDoctor(12334, "AA");
doc.DisplayDoctorDetails();
doc.ModifyDoctor(11111,"SS");
doc.DisplayDoctorDetails();
doc.BookApp(9999,"ee");
doc.DelApp("AA");

















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








