using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GameLibrary;
namespace ConsoleUI
{
    public class CharacterCreation
    {
        public static void CreateZombieHunterPlayer(Character player)
        {
            string input = "";
            //Sentinel to control loop
            bool charLoop = false;
            //Create keyboard object
            ConsoleKeyInfo keyboard = new ConsoleKeyInfo();
            //Clear current screen
            Console.Clear();
            //Show player creation instructions
            Console.WriteLine(StandardMessages.CreateCharacterDirections());
            Console.ReadLine();
            Console.Clear();
            do
            {
                //Character creation menu                 
                Console.Write(StandardMessages.DisplayCreateCharacterMenu());
                keyboard = Console.ReadKey();
                switch (keyboard.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        //Creat name and password
                        CreateNameAndPassword(player );
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        //Select player class
                        SelectPlayerClass(player,charLoop, keyboard);
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        //Select player race
                        SelectPlayerRace(player,charLoop, keyboard);
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        //Display created player information
                        DisplayPlayerInformation(player);

                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        //Test to ensure player completes character creation 
                        if (player.Name == "" || player.PlayerPassword == "" || player.PlayerClass == "" || player.PlayerRace == "")
                        {
                            Console.WriteLine("\nYou must complete all tasks to proceed!");
                            Console.ReadLine();
                        }
                        else
                        {
                            
                            charLoop = true;
                            Console.Clear();

                        }
                        break;
                    case ConsoleKey.Escape:
                        charLoop = true;
                        break;
                    default:
                        Console.WriteLine(StandardMessages.DisplayInvalidOption());
                        Console.ReadLine();
                        break;
                }
                Console.Clear();
            } while (charLoop == false);

        }
        public static void CreateNameAndPassword(Character player)
        {
            bool characterLoop = false;
            Console.Clear();
            char ch = '!';
            //Display username/password title block
            Console.WriteLine(GameLibrary.StandardMessages.DisplayNamePasswordTitle());
            //Get user name from user 
            Console.Write("Enter your name ==> ");
            string playerName = Console.ReadLine();
            player.Name = playerName;
            do
            {
                //Create Password
                Console.WriteLine(StandardMessages.DisplayPasswordCreationInformation());
                //Enter password
                Console.Write("Enter your Password ==> ");
                string passWord1 = Console.ReadLine();
                player.PlayerPassword = passWord1;
                //Reenter password to confirm they match
                Console.Write("Reenter your Password ==> ");
                string passWord2 = Console.ReadLine();
                //Determine password length meets guidelines
                if (passWord1.Length < 8 || passWord1.Length > 15)
                {
                    Console.WriteLine("Password must be 8 or more characters and not to exceed 15 characters!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (passWord1.Length >= 8 || passWord1.Length <= 15)
                {
                    for (int i = 0; i < passWord1.Length; i++)
                    {
                        //Check password for 1 uppercase, 1 lowercase, 1 digit, and 1 punctuation/////////////////////////////////////
                        if (!(char.IsUpper(passWord1[i])))
                        {
                            //player.Password = " ";
                        }
                        else if (char.IsUpper(passWord1[i]))
                        {
                            for (i = 0; i < passWord1.Length; i++)
                            {
                                if (!(char.IsLower(passWord1[i])))
                                {
                                    //player.Password = " ";
                                }
                                else if (char.IsLower(passWord1[i]))
                                {
                                    for (i = 0; i < passWord1.Length; i++)
                                    {
                                        if (!(char.IsDigit(passWord1[i])))
                                        {
                                            //player.Password = " ";

                                        }
                                        else if (char.IsDigit(passWord1[i]))
                                        {
                                            for (i = 0; i < passWord1.Length; i++)
                                            {
                                                if (!(char.IsPunctuation(passWord1[i])))
                                                {
                                                    //player.Password = " ";
                                                }
                                                else if (char.IsPunctuation(passWord1[i]))
                                                {

                                                    characterLoop = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
                if (characterLoop == false)
                {
                    Console.WriteLine("You failed to create an appropriate password! Try again!");
                }
                //Clear current screen
                Console.Clear();
            } while (characterLoop == false);
            //DIsplay password requirements met to user
            Console.WriteLine("Goodjob! Your password met the requirements. \n" +
                "Press Enter...");
            Console.ReadLine();
        }
        public static void SelectPlayerClass(Character player,bool characterLoop, ConsoleKeyInfo keyboard)
        {   //Select player class                    
            do
            {

                Console.Clear();
                Console.WriteLine(StandardMessages.DisplaySelectPlayerClass());
                keyboard = Console.ReadKey();
                switch (keyboard.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        player.PlayerClass = "Warrior";
                        characterLoop = true;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        player.PlayerClass = "Mage";
                        characterLoop = true;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        player.PlayerClass = "Thief";
                        characterLoop = true;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        player.PlayerClass = "Cleric";
                        characterLoop = true;
                        break;
                    case ConsoleKey.Escape:
                        characterLoop = true;
                        break;
                    default:
                        Console.WriteLine(StandardMessages.DisplayInvalidOption());
                        break;
                }
                Console.Clear();
            } while (characterLoop == false);
        }
        public static void SelectPlayerRace(Character player, bool characterLoop, ConsoleKeyInfo keyboard)
        {
            Console.Clear();
            //Select player race
            do
            {
                Console.WriteLine(StandardMessages.DisplaySelectPlayerRace());
                keyboard = Console.ReadKey();
                switch (keyboard.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        player.PlayerRace = "Human";
                        characterLoop = true;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        player.PlayerRace = "Elf";
                        characterLoop = true;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        player.PlayerRace = "Dwarf";
                        characterLoop = true;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        player.PlayerRace = "Wizard";
                        characterLoop = true;
                        break;
                    case ConsoleKey.Escape:
                        characterLoop = true;
                        break;
                    default:
                        Console.WriteLine(StandardMessages.DisplayInvalidOption());
                        break;
                }
                Console.Clear();
            } while (characterLoop == false);
        }
        public static void DisplayPlayerInformation(Character player)
        {
            //Display player information
            Console.Clear();
            Console.WriteLine($"Player Information\n----------------------\n" +
                $"Name: {player.Name}\nPassword: {player.PlayerPassword}\nCLass: {player.PlayerClass}\nRace: {player.PlayerRace}");
            Console.ReadLine();
        }
    }
}
