using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Create directory path for files
            string directory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //Declare and initialize variables
            bool mainMenuLoop = false;
            string documentName = "";
            int numbers = 0;
            string input = "";
            //Create keyboard object for user input
            ConsoleKeyInfo keyboard;
            do
            {
                //Display main menu to user
                DisplayDocuments.DisplayMainMenu();
                //Get keyboard input from user
                keyboard = Console.ReadKey();
                //Controls flow of main menu
                switch (keyboard.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        DisplayDocuments.DisplayStartGameMenu();
                        StartGame.StartZombieHunterGame();
                        
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                       

                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        
                        break;
                    case ConsoleKey.Escape:
                        //Ends program
                        mainMenuLoop = true;
                        break;

                    default:
                        //Displays invalid option
                        Console.WriteLine(GameLibrary.StandardMessages.DisplayInvalidOption());
                        break;

                }
                //Clears current screen
                Console.Clear();
            } while (mainMenuLoop == false);
        }
    }
}
