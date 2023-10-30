// See https://aka.ms/new-console-template for more information
using Assignment;
Circle circle = new Circle(3);
circle.Draw();
Rectangle rectangle = new Rectangle(5, 3);
rectangle.Draw();


/*
using static Assignment.ExceptionHandl.MyException;
while (true)
{
    Console.WriteLine("Choose your option\n 1.Add MedicalRecord\n 2.View MedicalRecord");
    int option = Convert.ToInt32(Console.ReadLine());
    FileStream fileStream = new FileStream("C:\\Users\\Administrator\\Desktop\\File\\MedicalRecord.txt",
        FileMode.Append, FileAccess.Write);
    StreamWriter writer = new StreamWriter(fileStream);


    switch (option)
    {
        case 1:
            Console.WriteLine("Enter the Record Id");
            int recordId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the patient Id");
            int patientId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Description");
            string? description = Console.ReadLine();
            Console.WriteLine("Enter the date");
            string? date = Console.ReadLine();


            MedicalHistory medicalHistory = new MedicalHistory();
            medicalHistory.RecordId = recordId;
            medicalHistory.PatientId = patientId;
            medicalHistory.Description = description;
            medicalHistory.Date = date;


            try
            {
                MedicalHistory.MedRecordInfo(recordId,patientId,description,date);
            }
            catch (ArgumentException ex) { Console.WriteLine(ex.Message); }

            writer.WriteLine("Record id:{0}\t patient Id:{1}\t Description is:{2}\t Date:{3}",
                recordId, patientId, description, date);
            break;


        case 2:

            writer.Close();
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\File\\MedicalRecord.txt",
                FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string? str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();


            }

            sr.Close();
            fs.Close();
            break;

    }
    writer.Close();
    Console.WriteLine("Do you want to continue\n1.yes \n2.no");
    int opp = Convert.ToInt32(Console.ReadLine());
    if (opp == 1)
    {
        continue;

    }
    else if (opp == 2)
    {
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("invalid input");
    }
}

*/





//Assignment 2
/*
while (true)
{
    Console.WriteLine("Choose your option\n 1.Add Patient\n 2.View patient");
    int option = Convert.ToInt32(Console.ReadLine());
    FileStream fileStream = new FileStream("C:\\Users\\Administrator\\Desktop\\File\\Patient1.txt",
        FileMode.Append, FileAccess.Write);
    StreamWriter writer = new StreamWriter(fileStream);


    switch (option)
    {
        case 1:
            Console.WriteLine("Enter the patientid");
            int patientId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the patient name");
            string? patientName = Console.ReadLine();
            Console.WriteLine("enter the age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the diagnosis");
            string? diagnosis = Console.ReadLine();

            Patient patient = new Patient();
            patient.PatientName = patientName;
            patient.PatientId = patientId;
            patient.Age = age;
            patient.Diagnosis = diagnosis;

            try
            {
                patient.AddPatient(patient);
            }
            catch (ArgumentException ex) { Console.WriteLine(ex.Message); }

            writer.WriteLine("patient id:{0}\t patient name:{1}\t age is:{2}\t Diagnosis:{3}",
                patientId, patientName, age, diagnosis);
            break;


        case 2:

            writer.Close();
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\File\\Patient1.txt",
                FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string? str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();


            }

            sr.Close();
            fs.Close();
            break;

    }
    writer.Close();
    Console.WriteLine("Do you want to continue\n1.yes \n2.no");
    int opp = Convert.ToInt32(Console.ReadLine());
    if (opp == 1)
    {
        continue;

    }
    else if (opp == 2)
    {
        Environment.Exit(0);
    }
    else {
        Console.WriteLine("invalid input");
    }
}
*/















//Assignment1 27/10/23
/*
try {
    MedicalRecord.AddMedicalRecords(1, "gg", "fever", 0);
        }
catch (InvalidPatientException ex) {
    Console.WriteLine(ex.Message);
}
catch(InvalidMedicalRecords ex)
{
    Console.WriteLine(ex.Message);
}
*/








/*
using System.Collections.Generic;

Patient pt = new(2,"anu",20,"dengue");
try
{
    pt.AddPatient(pt);
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}




//Assignment2
/*
CallRecord cal=new (112,34567889,1030);
CallRecord cal1 = new (113, 34562687, 1234);
CallRecord cal2 = new (114, 56743582, 1345);
CallRecord.calrd.Add(1, cal);
CallRecord.calrd.Add(2, cal1);
CallRecord.calrd.Add (3, cal2);
CallRecord.SearchRecord(34567889);
CallRecord.TotalCalls();
*/










/*Assignmnt1
Customer cos=new Customer(112,"Anu","999955567",4000);
Customer cos1=new Customer(113,"ammu","555677688",5000);
Customer cos2 = new Customer(114, "Anju", "5566443234", 6000);


Dictionary<int, Customer> costumer = new Dictionary<int, Customer>(); 

costumer.Add(1, cos);
costumer.Add(2, cos1);
costumer.Add(3, cos2);

findcustomer("999955567");
DisplayDetails();


void findcustomer(string phnnumber) { 

    foreach(var i  in costumer.Values)
    {
        if (phnnumber == i.PhoneNumber)
        {
            Console.WriteLine("Customer found is");
            Console.WriteLine(i.CustomerName);
            Console.WriteLine(i.BalanceAmount);
            break;
        }
        else
        { Console.WriteLine("Customer not found");
        }

        
    }
   
}
void DisplayDetails()
{
    foreach (var i in costumer.Values) {
        
        {
            Console.WriteLine("Customer name: {0}\n Custo NmaeoneNumber :{2}\n BalanceAmount:{3}",i. CustomerId,i.CustomerName,i.PhoneNumber,i.BalanceAmount);
        }
    }
}
*/


