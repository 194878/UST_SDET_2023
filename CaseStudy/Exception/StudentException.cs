using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Exception1
{
    internal class StudentException : Exception
    {
        public StudentException(string message) : base(message)
        {

        }
    }
}