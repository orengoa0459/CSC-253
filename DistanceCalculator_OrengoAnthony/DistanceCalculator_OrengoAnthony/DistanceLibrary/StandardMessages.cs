using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceLibrary
{
    public class StandardMessages
    {
        //Display main menu
        public static string DisplayMainMenu()
        {
            return "*************************\n" +
                   "*   Distance Calculator *\n" +
                   "*************************\n" +
                   "1. Enter Time and Speed\n" +
                   "2. Calculate Distance\n" +
                   "Esc. Exit\n" +
                   "\nMake a selection";
        }
        //Display title to user
        public static string DisplayCalculatorTitle()
        {
            return "*************************\n" +
                   "*  Distance Calculator  *\n" +
                   "*************************";

        }
        public static string DisplayFinalResultTitle()
        {
            return "*************************\n" +
                   "*  Distance Traveled  *\n" +
                   "*************************";

        }
        //Display enter time to user
        public static string DisplayEnterTime()
        {
            return "Enter hours traveled--> ";

        }
        //Display enter vehicle speed to user
        public static string DisplayEnterVehicleSpeed()
        {
            return "Enter Vehicle speed--> ";
        }

        //Display press enter to user
        public static string DisplayPressEnter()
        {
            return "\n\nPress Enter...";
        }
        //Display invalid option to user
        public static string DisplayInvalidOption()
        {
            return "\nNot a valid option! Press enter and try again!";
        }
    }
}
