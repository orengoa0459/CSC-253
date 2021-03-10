using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* Date 09.25.2020
* CSC 153
* Anthony Orengo
* Program description: This program asks the user to input the 
* vehicles speed and travel time(hours) and calculates the 
* distance the vehicle traveled.
*/
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize variables
            string input = "";
            double speed = 0.0;
            double hours = 0.0;
            double distance = 0.0;
            //Create keyboard object
            ConsoleKeyInfo keyboard = new ConsoleKeyInfo();
            //Declare and initialize sentinel
            bool menuLoop = false;

            do
            {
                //Display main menu
                Console.WriteLine(DistanceLibrary.StandardMessages.DisplayMainMenu());
                //get user input
                keyboard = Console.ReadKey();
                switch (keyboard.Key)
                {
                    case ConsoleKey.D1:
                        //Calculate vehicle distance
                        GetTravelData.GetSpeedAndTime(ref speed,ref hours,ref distance, menuLoop,ref input);
                        break;
                    case ConsoleKey.D2:
                        CalculateDistance.CalculateVehiclesDistance(ref speed, ref hours, ref distance, menuLoop, ref input);
                        break; ;
                    case ConsoleKey.Escape:
                        //End program
                        menuLoop = true;
                        break;
                    default:
                        //Display invalid selection
                        Console.WriteLine(DistanceLibrary.StandardMessages.DisplayInvalidOption());
                        Console.ReadLine();
                        break;
                }
                //Clears current screen
                Console.Clear();
            } while (menuLoop == false);
        }
    }
}
