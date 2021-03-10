using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public static class StandardMessages
    {
        public static string DisplayMainMenu()
        {
            //Displays main menu
            return "              Main Menu\n" +
            "***************************************\n" +
            "1. Enter employee's information\n" +
            "2. Enter manager's information\n" +
            "3. Display employee's information\n" +
            "4. Display manager's information\n" +
            "5. Display average age of employee's\n" +
            "6. Exit.\n" +
            "---------------------------------------\n " +

            "Make a selection --> ";

        }

        //Message to get users first name
        public static string GetEmployeesFirstName()
        {
            return "Enter first name -->";
        }
        //Message to get users last name
        public static string GetEmployeesLastName()
        {
            return "Enter  last name -->";
        }

        //Message to get user phone number
        public static string GetPhoneNumber()
        {
            return "Enter phone number -->";

        }

        //Message to get user age
        public static string GetEmployeesAge()
        {
            return "Enter Age -->";

        }
        public static string GetEmployeesBasePay()
        {
            return "Enter hourly wage -->";

        }
        public static string GetManagersPromotionDate()
        {
            return "Enter date of promotion -->";

        }

        //Message to display average employee age
        public static string DisplayAverageAge()
        {
            return "Average employee age";

        }
        public static string InvlaidNumber()
        {
            return "Not a valid number!";
        }
    }
}
