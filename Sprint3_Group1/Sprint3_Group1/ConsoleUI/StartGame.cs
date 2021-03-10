using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUI.PlayerDocuments;
using GameLibrary;
namespace ConsoleUI
{
    public class StartGame
    {
        public static void StartGameMenu()
        {
            Console.Clear();
            Character player = new Character();
            //Create directory path for files
            string directory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //Declare and initialize variables
            bool startGameMenuLoop = false;
            bool playerPassVerification = false;
            string input = "";
            //Create keyboard object for user input
            ConsoleKeyInfo keyboard = new ConsoleKeyInfo();
            //MainGameStart.StartZombieHunterGame(ref player);
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
                        CharacterCreation.CreateZombieHunterPlayer(ref player);
                        PlayerData.AddPlayerDataToDocument(ref player);
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        PlayerLogin.VerifyPlayerUserNamePassword(ref player, ref playerPassVerification);
                        if(playerPassVerification == true)
                        {
                            Console.Clear();
                            MainGameStart.StartZombieHunterGame(ref player); 
                        }
                        else
                        {
                            Console.WriteLine("Character not verified!");
                            Console.ReadLine();
                        }
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
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
