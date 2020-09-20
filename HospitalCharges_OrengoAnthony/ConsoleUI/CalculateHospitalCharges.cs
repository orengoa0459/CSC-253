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
        public static void CalcStayCharges(ref double totalDailyCharges, bool loop, string input)
        {
            //Declare and initialize variables
            double hours = 0.0;
            //Constant variable set to hospital daily rate
            const double DAILYRATE = 350;
            //Set sentinel for loop
            bool hourLoop = false;
            Console.Clear();
            do
            {
                //Get total number of overnight stays from user
                Console.WriteLine(HospitalLibrary.StandardMessages.DisplayOvernightTitle());
                Console.WriteLine(HospitalLibrary.StandardMessages.GetOvernightStay());
                input = Console.ReadLine();
                if (double.TryParse(input, out totalDailyCharges))
                {
                    //Decision structure to determine if overnight stay is less than 24hours
                    if(totalDailyCharges > 0)
                    {
                        totalDailyCharges = totalDailyCharges * DAILYRATE;
                        loop = true;
                    }
                    //If overnight stay is less than 24hrs calculate hospital stay by hours
                    else
                    {
                        do
                        {
                            Console.Write("Enter total hours at hospital -->");
                            input = Console.ReadLine();
                            if (double.TryParse(input, out hours))
                            {
                                hours = hours / 24;
                                totalDailyCharges = hours * DAILYRATE;
                                hourLoop = true;
                                loop = true;
                                Console.WriteLine($"Total Cost: {totalDailyCharges}");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                //Display invalid selection
                                Console.WriteLine(HospitalLibrary.StandardMessages.InvalidInput());
                                Console.Clear();
                            }

                        } while (hourLoop == false);                                               
                    }                    
                }
                else
                {
                    //Display invalid input
                    Console.WriteLine(HospitalLibrary.StandardMessages.InvalidInput());
                    Console.WriteLine(HospitalLibrary.StandardMessages.DisplayPressEnter());
                    Console.ReadLine();                    
                    Console.Clear();
                }

            } while (loop == false);        

        }
        public static void CalcMiscCharges(ref double totalMiscCharges, bool medLoop, string input)
        {
            //Declare and initialize variables
            double medication = 0.0;
            double surgicalCharge = 0.0;
            double labCharge = 0.0;
            double rehabCharge = 0.0;
            //Declare and initialize sentinels
            bool surgLoop = false;
            bool labLoop = false;
            bool rehabLoop = false;

            //MEDICATION LOOP
            do
            {
                Console.Clear();
                Console.WriteLine(HospitalLibrary.StandardMessages.DisplayMedicationTitle());
                Console.WriteLine(HospitalLibrary.StandardMessages.GetMedicationCost());
                //Get cost of medication from user
                input = Console.ReadLine();
                if (double.TryParse(input, out medication))
                {
                    medLoop = true;
                }
                else
                {
                    //Display invalid input
                    Console.WriteLine(HospitalLibrary.StandardMessages.InvalidInput());
                    Console.WriteLine(HospitalLibrary.StandardMessages.DisplayPressEnter());
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (medLoop == false);
            //SURGICAL LOOP
            do
            {
                Console.Clear();
                Console.WriteLine(HospitalLibrary.StandardMessages.DisplaySurgicalTitle());
                Console.WriteLine(HospitalLibrary.StandardMessages.GetSurgicalCost());
                //Get surgical cost from user
                input = Console.ReadLine();
                if (double.TryParse(input, out surgicalCharge))
                {
                    surgLoop = true;
                }
                else
                {
                    //Display invalid input
                    Console.WriteLine(HospitalLibrary.StandardMessages.InvalidInput());
                    Console.WriteLine(HospitalLibrary.StandardMessages.DisplayPressEnter());
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (surgLoop == false);
            //LAB FEE LOOP
            do
            {
                Console.Clear();
                Console.WriteLine(HospitalLibrary.StandardMessages.DisplayLabFeeTitle());
                Console.WriteLine(HospitalLibrary.StandardMessages.GetLabFee());
                //Get lab fee from user
                input = Console.ReadLine();
                if (double.TryParse(input, out labCharge))
                {
                    labLoop = true;
                }
                else
                {
                    //Display invalid input
                    Console.WriteLine(HospitalLibrary.StandardMessages.InvalidInput());
                    Console.WriteLine(HospitalLibrary.StandardMessages.DisplayPressEnter());
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (labLoop == false);
            //REHAB LOOP
            do
            {
                Console.Clear();
                Console.WriteLine(HospitalLibrary.StandardMessages.DisplayRehabTitle());
                Console.WriteLine(HospitalLibrary.StandardMessages.GetRehabCost());
                //Get rehab cost from user
                input = Console.ReadLine();
                if (double.TryParse(input, out rehabCharge))
                {
                    rehabLoop = true;
                    Console.Clear();
                }
                else
                {
                    //Display invalid input
                    Console.WriteLine(HospitalLibrary.StandardMessages.InvalidInput());
                    Console.WriteLine(HospitalLibrary.StandardMessages.DisplayPressEnter());
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (rehabLoop == false);
            //Calculate misc charges
            totalMiscCharges = medication + surgicalCharge + labCharge + rehabCharge;
            //Console.WriteLine($"Total Misc Charges: {totalMiscCharges}");            
        }
        public static void CalcTotalCharges(ref double totalHospitalCharges, ref double  totalDailyCharges, ref double totalMiscCharges,ref List<Patient> patientBill,Patient patientName, string input)
        {
            Console.Clear();
            bool nameLoop = false;
            //Calculate and display Hospital bill
            totalHospitalCharges = totalDailyCharges + totalMiscCharges;
            Console.WriteLine(HospitalLibrary.StandardMessages.DisplayHospitalBill(ref totalHospitalCharges, ref totalDailyCharges, ref totalMiscCharges));                        
            //Determine if data has been entered by user. Information will not be added to list if data is missing.
            if(totalHospitalCharges == 0 && totalMiscCharges == 0 && totalDailyCharges == 0)
            {
                Console.WriteLine("No data was entered!");                
            }
            
            else if (totalHospitalCharges == 0)
            {
                Console.WriteLine("Missing hospital charges");
            }
            else
            {
                do
                {
                    //Get patient forst name            
                    Console.Write(HospitalLibrary.StandardMessages.DisplayEnterPatientFName());
                    input = Console.ReadLine();
                    patientName.FirstName = input;
                    //Get patient last name
                    Console.Write(HospitalLibrary.StandardMessages.DisplayEnterPatientLName());
                    input = Console.ReadLine();
                    patientName.LastName = input;
                    if (patientName.FirstName == "" && patientName.LastName == "")
                    {
                        Console.WriteLine(HospitalLibrary.StandardMessages.InvalidPatientLName());
                        Console.WriteLine(HospitalLibrary.StandardMessages.DisplayPressEnter());
                        
                    }
                    else
                    {
                        nameLoop = true;
                    }

                } while (nameLoop == false);
                //Add patient data to Patient List
                patientBill.Add(new Patient("Patient Name:", patientName.FirstName, patientName.LastName, "\nTotal Bill:", totalHospitalCharges));                
            }            
            Console.WriteLine(HospitalLibrary.StandardMessages.DisplayPressEnter());
            Console.ReadLine();
            Console.Clear();
        }
    }
}
