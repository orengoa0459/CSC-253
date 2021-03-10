using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalLibrary;
namespace ConsoleUI
{


    public class CalculateHospitalCharges
    {
        public static void CalcStayCharges(ref double totalDailyCharges, string input)
        {
            double day = 0.0;
            double dailyRate = 350;
            Console.WriteLine(HospitalLibrary.StandardMessages.GetOvernightStay());
            input = Console.ReadLine();
            if(double.TryParse(input, out day))
            {

            }
            else
            {
                Console.WriteLine(HospitalLibrary.StandardMessages.InvalidSelection());
            }
            //Console.WriteLine(HospitalLibrary.StandardMessages.GetDailyRate());
            //input = Console.ReadLine();
            //if (double.TryParse(input, out dailyRate))
            //{

            //}
            //else
            //{
            //    Console.WriteLine(HospitalLibrary.StandardMessages.InvalidSelection());
            //}
            totalDailyCharges = day * dailyRate;
            //Console.WriteLine($"Daily Rate: {totalDailyCharges}");           

        }
        public static void CalcMiscCharges(ref double totalMiscCharges, string input)
        {
            double medication = 0.0;
            double surgicalCharge = 0.0;
            double labCharge = 0.0;
            double rehabCharge = 0.0;
            Console.WriteLine(HospitalLibrary.StandardMessages.GetMedicationCost());
            input = Console.ReadLine();
            if (double.TryParse(input, out medication))
            {

            }
            else
            {
                Console.WriteLine(HospitalLibrary.StandardMessages.InvalidSelection());
            }
            Console.WriteLine(HospitalLibrary.StandardMessages.GetSurgicalCost());
            input = Console.ReadLine();
            if (double.TryParse(input, out surgicalCharge))
            {

            }
            else
            {
                Console.WriteLine(HospitalLibrary.StandardMessages.InvalidSelection());
            }
            Console.WriteLine(HospitalLibrary.StandardMessages.GetLabFee());
            input = Console.ReadLine();
            if (double.TryParse(input, out labCharge))
            {

            }
            else
            {
                Console.WriteLine(HospitalLibrary.StandardMessages.InvalidSelection());
            }
            Console.WriteLine(HospitalLibrary.StandardMessages.GetRehabCost());
            input = Console.ReadLine();
            if (double.TryParse(input, out rehabCharge))
            {

            }
            else
            {
                Console.WriteLine(HospitalLibrary.StandardMessages.InvalidSelection());
            }
            totalMiscCharges = medication + surgicalCharge + labCharge + rehabCharge;
            //Console.WriteLine($"Total Misc Charges: {totalMiscCharges}");            
        }
        public static void CalcTotalCharges(ref double totalHospitalCharges, ref double  totalDailyCharges, ref double totalMiscCharges, string input)
        {            
            totalHospitalCharges = totalDailyCharges + totalMiscCharges;
            //Console.WriteLine($"Total Charges: {totalHospitalCharges}");            
        }
    }
}
