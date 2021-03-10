using ConsoleUI.PlayerMovementFolder;
using ConsoleUI.Scenario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;
namespace ConsoleUI
{
    public class Movement
    {
        public static void PlayerMovement(ref Character player, string input, ref int locOne, ref int locTwo, ref string[,] map1, ref string locationName)
        {
           
            #region Map1 Layout
            // Legend
            /* W = wall, 
             * M = Map, 
             * G = weapon, 
             * C = Coins, 
             * Z = Zombie*/
            //MAP 1------------------------------------
            map1 = new string[,]
            { {"W","W","W","W","W","W"}, 
              {"S","W","M"," ","G","W"},
              {"E","P"," "," "," ","E"},
              {"W","W"," ","C"," ","W"},
              {"W","W","W","W","W","W"}};
            //--------------------------------------------
            locationName = map1[locOne, locTwo];
            if(locationName == "S")
            {
                locationName = "Start Point";
            }
            else if (locationName == "W")
            {
                locationName = "Wall";
            }
            else if (locationName == " ")
            {
                locationName = "Kitchen";
            }
            else if (locationName == "M")
            {
                locationName = "Map Pickup";
            }
            else if (locationName == "C")
            {
                locationName = "Coins";
            }
            else if (locationName == "G")
            {
                locationName = "Gun Pickup";
            }
            else if (locationName == "P")
            {
                locationName = "Puzzle";
            }
            else if (locationName == "E")
            {
                locationName = "Entrance/Exit";
            }
            #endregion

            //Display player information
            Console.WriteLine($"Current Location: {locationName}");
            Console.WriteLine("Choose your direction: ");
            LocationVerification.DisplayPlayerMovementOptions(input, ref locOne, ref locTwo, ref map1);
            ScenarioVerification.PlayerLocationScenarios(ref player,input, ref locOne, ref locTwo, ref map1);

            #region Player Movement (switch)
            input = Console.ReadLine();

            switch (input)
            {
                case "go north":
                case "Go North":
                    if (locOne > 0 && locTwo >= 0)
                    {
                        if (map1[locOne, locTwo].Equals("W"))
                        {
                            Console.WriteLine("You reached a wall!");
                          
                        }
                        else
                        {
                            locOne--;
                        }
                    }
                    break;
                case "go south":
                case "Go South":
                    if (locOne > 0 && locTwo >= 0)
                    {
                        if (map1[locOne, locTwo].Equals("W"))
                        {
                            Console.WriteLine("You reached a wall!");
                            
                        }
                        else
                        {
                            locOne++;
                        }
                    }
                    break;
                //TODO-------------------------------------------------
                case "go west":
                case "Go West":
                    if (locOne > 0 && locTwo >= 0)
                    {
                        if (map1[locOne, locTwo] != "W")
                        {
                            locTwo--;
                           
                            
                        }
                        else
                        {
                            Console.WriteLine("You reached a wall!");
                            if (locOne == 1 && locTwo == 1)
                            {
                                locOne = 1;
                                locTwo = 0;
                            }
                        }

                    }
                    break;
                //TODO-------------------------------------------------
                case "go east":
                case "Go East":
                    if (locOne > 0 && locTwo >= 0)
                    {
                        if (map1[locOne, locTwo] != "W")
                        {
                            locTwo++;

                        }
                        else
                        {
                            Console.WriteLine("You reached a wall!");
                            if (locOne == 1 && locTwo == 1)
                            {
                                locOne = 1;
                                locTwo = 0;
                            }
                        }

                    }
                    break;

            }
            #endregion Player Movement (Switch)

        }
    }
}
