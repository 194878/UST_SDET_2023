using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Customer
    {
        public Customer(int customerId, string customerName, string? phoneNumber, double balanceAmount)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            PhoneNumber = phoneNumber;
            BalanceAmount = balanceAmount;
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string? PhoneNumber { get; set; }
        public double BalanceAmount { get; set; }


       
        
            
        
        
    }
}
