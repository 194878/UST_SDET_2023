// See https://aka.ms/new-console-template for more information
using Assignment;
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


