using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary
{
    public class StandardMessages
    {

        public static string MainMenu()
        {
            return "1. Enter Hospital Stay\n" +
                "2. Enter Misc Charges\n" +
                "3. Calculate Total Charges\n" +
                "4. Display Total Hospital Bill\n" +
                "5. Exit\n";
               
        }
       
        public static string GetMedicationCost ()
        {
            return "Enter patients medication cost--> ";
        }
        public static string GetSurgicalCost()
        {
            return "Enter patients surgical cost--> ";
        }
        public static string GetLabFee()
        {
            return "Enter patients lab fee--> ";
        }
        public static string GetRehabCost()
        {
            return "Enter patients rehabilitation cost--> ";
        }
        public static string GetDailyRate()
        {
            return "Enter hospitals daily rate--> ";
        }
        public static string GetOvernightStay()
        {
            return "Enter amount of overnight days--> ";
        }
        public static string DisplayPressEnter()
        {
            return "Press Enter...";
        }
        public static string InvalidSelection()
        {
            return "Invalid selection! Try again...";
        }
    }
}
