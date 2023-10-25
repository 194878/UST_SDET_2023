// See https://aka.ms/new-console-template for more information
using Assignment;

LifeInsurance li=new(30,"pp12",112,2000);
Console.WriteLine($"Policy Name:{li.PolicyName}\nPolicy Id{li.PolicyId}\nPremium:{li.PremiumAmount}\nsuminsured:{li.CalculatePremium()}");

CarInsurance car=new ("sedan","pp13",113,3000);
Console.WriteLine($"Policy Name:{car.PolicyName}\nPolicy Id{car.PolicyId}\nPremium:{car.PremiumAmount}\nsuminsured:{car.CalculatePremium()}");






//InsurancePolicy np = new InsurancePolicy("AA", 112, 30000);
//np.RenewPolicy(12000);
//InsurancePolicy np1=new InsurancePolicy("BB",111,20000);
//np.RenewPolicy();