using Assignment.ExceptionHandl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment.ExceptionHandl.MyException;

namespace Assignment
{
    internal class MedicalRecord : Patient
    {
        
       
        public int RecordId { get; set; }
        

        public int TreatmentCost { get; set; }

        public static List<MedicalRecord> medicalRecords = new List<MedicalRecord>();

        public static  void AddMedicalRecords(int recordId,string? patientName, string? diagnosis, int treatmentCost)
        {

            if (recordId <= 0) {
                throw new InvalidMedicalRecords(MyException.error["one"]);
            }
            if (string.IsNullOrEmpty(diagnosis))
            {
                throw new InvalidMedicalRecords(MyException.error["three"]);
            }
            if (string.IsNullOrEmpty(patientName))
            {
                throw new InvalidPatientException(MyException.error["two"]);
            }
            if (treatmentCost>=0) {

                throw new InvalidMedicalRecords(MyException.error["four"]);
            }
            MedicalRecord medicalRecord = new MedicalRecord();
            medicalRecord.RecordId = recordId;
            medicalRecord.PatientName = patientName;
            medicalRecord.TreatmentCost = treatmentCost;




        }




    }
}
