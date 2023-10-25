using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class InsurancePolicy
    {
        public InsurancePolicy(string? policyName, int policyId, double premiumAmount)
        {
            this.policyName = policyName;
            this.policyId = policyId;
            this.premiumAmount = premiumAmount;
        }

        public string? policyName { get; set; }
        public int policyId { get; set; }
        public double premiumAmount { get; set; }

        public void RenewPolicy(double newPremiumAmount ) {

            premiumAmount = newPremiumAmount;
            Console.WriteLine(" Policy Name: {0}\n ,Policy Id: {1}\n, Updated premium amount:{2}",policyName,policyId ,premiumAmount);

        }
        public void RenewPolicy()
        {
            premiumAmount += (premiumAmount * 0.1);
            Console.WriteLine(" Policy Name: {0}\n ,Policy Id: {1}\n, Updated premium amount:{2}", policyName, policyId, premiumAmount);
        }
       
    }
}
