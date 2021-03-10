using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;
using System.IO;
namespace ConsoleUI.MenuItems
{
    public class OptionsMenu
    {
        public static void MenuOptionSelection()
        {
            Console.Clear();
            bool menuLoop = false;
            //Create keyboard object for user input
            ConsoleKeyInfo keyboard;
            do
            {
                //Display main menu to user
                DisplayDocuments.DisplayOptionsMenu();
                //Get keyboard input from user
                keyboard = Console.ReadKey();
                //Controls flow of main menu
                Console.ForegroundColor = ConsoleColor.White;
                switch (keyboard.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        DisplayDocuments.DisplayMobs();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:


                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        break;
                    case ConsoleKey.Escape:
                        //Ends program
                        menuLoop = true;
                        break;

                    default:
                        //Displays invalid option
                        Console.WriteLine(GameLibrary.StandardMessages.DisplayInvalidOption());
                        break;

                }
                //Clears current screen
                Console.Clear();
            } while (menuLoop == false);
        }
    }
}
