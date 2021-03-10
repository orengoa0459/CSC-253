using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;
namespace ConsoleUI
{
    public class StartGame
    {
        public static void StartZombieHunterGame()
        {
            Console.Clear();
            Character player = new Character();
            //Create directory path for files
            string directory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //Declare and initialize variables
            bool startGameMenuLoop = false;           
            string input = "";
            //Create keyboard object for user input
            ConsoleKeyInfo keyboard = new ConsoleKeyInfo();
            do
            {
                //Display main menu to user
                DisplayDocuments.DisplayStartGameMenu();
                //Get keyboard input from user
                keyboard = Console.ReadKey();
                //Controls flow of main menu
                switch (keyboard.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        CharacterCreation.CreateZombieHunterPlayer(player);

                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        //TODO Create player two game path

                        break;
                    case ConsoleKey.Escape:
                        //Ends program
                        startGameMenuLoop = true;
                        break;

                    default:
                        //Displays invalid option
                        Console.WriteLine(GameLibrary.StandardMessages.DisplayInvalidOption());
                        break;

                }
                
                //Clears current screen
                Console.Clear();
            } while (startGameMenuLoop == false);

        }
    }
}
