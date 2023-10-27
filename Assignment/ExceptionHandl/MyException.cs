using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ExceptionHandl
{
    internal class MyException
    {
        public static Dictionary<string, string> error = new Dictionary<string, string>()
        {
        {"one","Id is incorrect"},
        {"two","Patient name is not null or empty"},
        {"three","diagnosed as fever"},
        {"four","total cost is greater than 0"}
};

         internal class InvalidPatientException:Exception 
        {
            public InvalidPatientException(string? message):base(message) { 

            }
        }
        internal class InvalidMedicalRecords : Exception
        { 
            public InvalidMedicalRecords(string? message):base(message) { }
        }
    }
}
