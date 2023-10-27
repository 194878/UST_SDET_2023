using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Patient
    {
        public int PatientId { get; set; }
        public string? PatientName { get; set; }
        public int Age { get; set; }
        public string? Diagnosis { get; set; }

        List<Patient> Patients = new List<Patient>();

       

        public void AddPatient(Patient patient) {
            if ((patient.Age < 0 || patient.Age > 120))
            {
                throw new ArgumentException("age is between 0 and 120");
            }
            else if (patient.PatientName == "" || patient.Diagnosis == "")
            {
                throw new ArgumentException("patient name and diagnosis should not be null"); }
            else
            {
                Patients.Add(patient);
                Console.WriteLine("Patient added");
            }
        }
       
    }
}
