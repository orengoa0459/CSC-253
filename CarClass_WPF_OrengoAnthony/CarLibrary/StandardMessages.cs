using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class StandardMessages
    {
        //Displays menu options
        public static string CarMenu()
        {
            return " Main Menu \n-----------------------\n" +
                " 1. Create car\n 2. Accelerate\n 3. Brake\n " +
                "4. Display vehicle infromation\n 5. Exit\n" +
                "-----------------------\n";
                
        }
        //Message to get vehicle year
        public static string EnterYear()
        {
            return "Enter vehicle year --> ";
        }
        //Message to get vehicle make
        public static string EnterMake()
        {
            return "Enter vehicle make --> ";
        }
        //Message to get vehicle speed
        public static string EnterSpeed()
        {
            return "Enter vehicle speed --> ";
        }
        //Message to display vehicle information
        public static string DisplayVehicleInformation(string year, string make, int speed)
        {
            return $"\n Vehicle Information\n----------------------\n" +
                $" Vehicle year: {year}\n Vehicle Make: {make}\n Vehicle speed: {speed}\n\n Press enter to continue.";
        }
        public static string InvalidChoice()
        {
            //Displays invalid choice
            return "Not a valid choice! ";
        }
    }
}
