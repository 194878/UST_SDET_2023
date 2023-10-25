using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class LifeInsurance : AbstactInsurance
    {
        public LifeInsurance(int age,string? policyName,int policyId, double premiumAmount)
        {
            Age = age;
            PolicyName = policyName;
            PolicyId= policyId;
            PremiumAmount = premiumAmount;


        }

        public int Age { get; set; }



        public override double CalculatePremium()
        {
            if (Age >= 18)
                PremiumAmount = 1000;
            else if (Age >= 19 && Age < 30)
                PremiumAmount = 2000;
            else if (Age >= 31 && Age <= 50)
                PremiumAmount = 3000;
            else
                PremiumAmount = 4000;
            return PremiumAmount;
        }
    }
}
