using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class CallRecord
    {
        public CallRecord(int callId, double phoneNumber, double callTime)
        {
            CallId = callId;
            PhoneNumber = phoneNumber;
            CallTime = callTime;
        }

        public int CallId { get; set; }

        public double PhoneNumber { get; set; }
        public double CallTime { get; set; }

        public static Dictionary<int, CallRecord> calrd = new Dictionary<int, CallRecord>();
        public static void SearchRecord(double phnumber)
        {
            foreach (var i in calrd.Values)
            {
                if (phnumber == i.PhoneNumber)
                {
                    Console.WriteLine("CallId:{0}\n CallTime:{1}", i.CallId, i.CallTime);

                }

            }
        }
        public static void TotalCalls()
        {
            Dictionary<double, int> totcall = new Dictionary<double, int>();
            foreach (var i in calrd.Values)
            {
                if (totcall.ContainsKey(i.PhoneNumber))
                {
                    totcall[i.PhoneNumber]++;
                }
                else
                {
                    totcall[i.PhoneNumber] = 1;
                }
            }
            foreach (var i in totcall)

            {
                Console.WriteLine("phonenumber:{0}\n ", i.Key, i.Value);
            }
        }
    }
}


