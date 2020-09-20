using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HospitalLibrary;
namespace ConsoleUI
{
    public class DisplayHospitalCharges
    {
        public static void HospitalBillTracker(ref double totalHospitalCharges, ref double totalDailyCharges, ref double totalMiscCharges,ref List<Patient> patientBill,
            Patient patientName, string input)
        {         
            //Set counter for patient#
            int count = 1;
            Console.Clear();
            //Display patient tracker title
            Console.WriteLine(HospitalLibrary.StandardMessages.DisplayTrackerTitle());
            //Display elements in Patient list            
                foreach (var element in patientBill)
                {
                    Console.WriteLine($"Patient# {count} \n{element.StrName} {element.FirstName} {element.LastName}{element.StrBill} {element.TotalCharges}\n");
                    count++;
                }
            Console.WriteLine(HospitalLibrary.StandardMessages.DisplayPressEnter());
            //***Resets data***
            totalDailyCharges = totalDailyCharges * 0;
            totalMiscCharges = totalMiscCharges * 0;
            totalHospitalCharges = totalHospitalCharges * 0;
            Console.ReadLine();
        }
    }
}
