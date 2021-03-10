using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class StandardMessages
    {
        #region Player Creation Instructions
        public static string CreateCharacterDirections()
        {
            return "****Instructions****\n" +
                "To create a character for Zombie Adventure you must ensure\n" +
                "you complete all tasks***. The list below explains the tasks.\n" +
                "\n" +
                "1. Create user name\n" +
                "2. Create password**\n" +
                "3. Select player Class\n" +
                "4. Select player race\n" +
                "\n" +
                $"{Console.ForegroundColor = ConsoleColor.Red} Note:\n" +
                "*** In order to proceed to the game, you must complete ALL TASKS.\n" +
                "**  Ensure you read the password instructions. Your password must fit\n" +
                "the criteria in order to proceed to the next task.\n" +
                "\n" +
                "Press enter to continue....";
        }

        #endregion
        //Display create character menu to the user

        #region Player Creation Menu
        public static string DisplayCreateCharacterMenu()
        {
            return
            "***************************************\n" +
            "*           Create Character          *\n" +
            "***************************************\n" +
            "*                                     *\n" +
            "*  1. Enter Name/Password             *\n" +
            "*  2. Choose Class                    *\n" +
            "*  3. Choose Race                     *\n" +
            "*  4. Display Player                  *\n" +
            "*  5. Finish                          *\n" +
            "*  Esc. Return to previous Screen     *\n" +
            "*                                     *\n" +
            "***************************************\n" +
            "Select from the menu ==> ";
        }
        #endregion


        public static string DisplayNamePasswordTitle()
        {
            return
            "**********************************\n" +
            "*         Name/Password          *\n" +
            "**********************************\n";
        }
        //Display Password creation instructions
        public static string DisplayPasswordCreationInformation()
        {
            return "Password Creation Guidelines:\n" +
                " \n" +
                "* Your password must contain 1 upper case, 1 lower case, 1 number, and an !.\n" +
                "* Ensure both passwords match.\n" +
                "* Ensure your password is greater than 8 characters.\n" +
                "* Ensure password length does not exceed 15 characters.";
        }
        //Display invalid option to user
        public static string DisplayInvalidOption()
        {
            return "Invalid Option! Try Again!";
        }
        //Display select player class to the user
        public static string DisplaySelectPlayerClass()
        {
            return
            "***************************************\n" +
            "*             Character Class         *\n" +
            "***************************************\n" +
            "*                                     *\n" +
            "*  1. Warrior                         *\n" +
            "*  2. Mage                            *\n" +
            "*  3. Thief                           *\n" +
            "*  4. Cleric                          *\n" +
            "*  Esc. Exit                            *\n" +
            "***************************************\n" +
            "Select your class...";
        }
        //Display select player race to the user
        public static string DisplaySelectPlayerRace()
        {
            return
           "***************************************\n" +
           "*             Character Race          *\n" +
           "***************************************\n" +
           "*                                     *\n" +
           "*  1. Human                           *\n" +
           "*  2. Elf                             *\n" +
           "*  3. Dwarf                           *\n" +
           "*  4. Wizard                          *\n" +
           "*  Esc. Exit                            *\n" +
           "***************************************\n" +
           "Select your race...";

        }
        //Display Player Stats

    }
}
