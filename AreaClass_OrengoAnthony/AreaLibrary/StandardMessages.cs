using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    public class StandardMessages
    {
        //Displays main menu items
        public static string DisplayMenu()
        {
            return "**************************************\n" +
                   "*          Area Calculator           *\n" +
                   "**************************************\n" +
                "1. Calculate the area of a Rectangle\n" +
                "2. Calculate the area of a circle\n" +
                "3. Calculate the area of a cylinder\n" +
                "Esc. Exit";
        }
        //Displays rectangle title
        public static string DisplayRectangleTitle()
        {
            return "********************************\n" +
                   "*        Rectangle Area        *\n" +
                   "********************************";                              
        }
        //Displays circle title
        public static string DisplayCircleTitle()
        {
            return "********************************\n" +
                   "*         Circle Area          *\n" +
                   "********************************";
        }
        //Displays cylinder title
        public static string DisplayCylinderTitle()
        {
            return "********************************\n" +
                   "*        Cylinder Area         *\n" +
                   "********************************";
        }
        //Displays "Press enter" to user
        public static string DisplayPressEnter()
        {
            return "Press Enter...";
        }
        //Displays "Invalid input" to user
        public static string DisplayInvalidInput()
        {
            return "Invalid input! Try again...";
        }
    }
}
