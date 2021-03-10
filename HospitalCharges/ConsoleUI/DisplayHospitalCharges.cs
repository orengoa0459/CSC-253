using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class DisplayHospitalCharges
    {
        public static void CalculateTotalHospitalCharges(ref double totalHospitalCharges, ref double totalDailyCharges, ref double totalMiscCharges, string input)
        {
            Console.WriteLine($"\n*********************\n " +
                $"    Hospital Bill\n" +
                $"*********************\n" +
                $"Hospital stay charge: {totalDailyCharges}\n" +
                $"Misc charges: {totalMiscCharges} \n" +
                $"Total: {totalHospitalCharges}");


            Console.ReadLine();
            Console.WriteLine(HospitalLibrary.StandardMessages.DisplayPressEnter());
        }
    }
}
