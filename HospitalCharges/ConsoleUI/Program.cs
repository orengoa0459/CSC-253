using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalLibrary;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;            
            bool menuLoop = false;
            double totalDailyCharges = 0.0;
            double totalMiscCharges = 0.0;
            double totalHospitalCharges = 0.0;
            
            do
            {
                Console.WriteLine(HospitalLibrary.StandardMessages.MainMenu());
                input = Console.ReadLine();

                switch (input)               
                {
                    case "1":
                        CalculateHospitalCharges.CalcStayCharges(ref totalDailyCharges, input);
                        break;
                    case "2":
                        CalculateHospitalCharges.CalcMiscCharges(ref totalMiscCharges, input);                       
                        break;
                    case "3":
                        CalculateHospitalCharges.CalcTotalCharges(ref totalHospitalCharges, ref totalDailyCharges, ref totalMiscCharges, input);
                        break;
                    case "4":
                        DisplayHospitalCharges.CalculateTotalHospitalCharges(ref totalHospitalCharges, ref totalDailyCharges, ref totalMiscCharges, input);                        
                        break;
                    case "5":
                        menuLoop = true;
                        break;
                    default:
                        Console.WriteLine(HospitalLibrary.StandardMessages.InvalidSelection());
                        break;
                }
            } while (menuLoop == false);
        }
    }
}
