using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class CarInsurance : AbstactInsurance

    {
        public CarInsurance(string? carType, string? policyName,int policyId,double premiumAmount)
        {
            CarType = carType;
            PolicyName = policyName;
            PolicyId = policyId;
            PremiumAmount = premiumAmount;
        }

        public string? CarType { get; set; }

        public override double CalculatePremium()
        {
            if (CarType == "sedan")
            {


                return PremiumAmount * .1;
            }
            else if (CarType == "suv")
            {

                return PremiumAmount * .2;
            }
            else
                return PremiumAmount;


        }
    }
}
