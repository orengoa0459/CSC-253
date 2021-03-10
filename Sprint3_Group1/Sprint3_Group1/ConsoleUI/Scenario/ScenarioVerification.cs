using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;
namespace ConsoleUI.Scenario
{
    public class ScenarioVerification
    {
        public static void PlayerLocationScenarios(ref Character player, string input, ref int locOne, ref int locTwo, ref string[,] map1)
        {
            string type = "";
            if (locOne == 2 && locTwo == 1)
            {
                type = "PuzzleOne";
                PlayerPuzzles(ref player, input, ref locOne, ref locTwo, ref map1,ref type);
            }
        }



        public static void PlayerPuzzles(ref Character player, string input, ref int locOne, ref int locTwo, ref string[,] map1, ref string type)
        {
            #region Puzzle Scenarios
            ConsoleKeyInfo keyboard = new ConsoleKeyInfo();
            bool doorAccess = false;
            int userCode = 0;
            int doorCode = 021918;
            #endregion
            #region 
            if (type.Equals("PuzzleOne"))
            {
                do
                {
                    Console.WriteLine("**********************\n" +
                                      "    Enter Door Code    \n\n" +
                                      "**********************\n" +
                                      "1. Enter Code\n" +
                                      "esc. Exit");

                    keyboard = Console.ReadKey();
                    switch (keyboard.Key)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            Console.Write("Enter Door Code -->(Testing Mode Only Door code is: 021918) ");
                            input = Console.ReadLine();
                            if (int.TryParse(input, out userCode))
                            {
                                
                                if (userCode == doorCode)
                                {
                                    Console.WriteLine("You unlocked the door! Enter....");
                                    locOne = 2; locTwo = 2;
                                       
                                    doorAccess = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Door Code! Try Again!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid Door Code! Try Again!");

                            }

                            break;

                        case ConsoleKey.Escape:
                            locOne = 2;
                            locTwo = 0;
                            doorAccess = true;
                            break;
                    } 

                    
                    

                } while (doorAccess == false);
                #endregion
            }
            else
            {

            }

        }
    }
}
