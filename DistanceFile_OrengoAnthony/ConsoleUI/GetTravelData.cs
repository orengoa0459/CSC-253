using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class GetTravelData
    {
        public static void GetSpeedAndTime(ref double speed, ref double hours, ref double distance, bool distanceLoop1, ref string input)
        {
            Console.Clear();
            distanceLoop1 = false;
            bool distanceLoop2 = false;

            do
            {
                //Display title to user
                Console.WriteLine(DistanceLibrary.StandardMessages.DisplayCalculatorTitle());
                //Get user to input vehicle speed
                Console.Write(DistanceLibrary.StandardMessages.DisplayEnterVehicleSpeed());
                input = Console.ReadLine();
                if (double.TryParse(input, out speed))
                {
                    do
                    {
                        //Clear current screen
                        Console.Clear();
                        Console.WriteLine(DistanceLibrary.StandardMessages.DisplayCalculatorTitle());
                        //Get user to input time traveled
                        Console.Write(DistanceLibrary.StandardMessages.DisplayEnterTime());
                        input = Console.ReadLine();
                        if (double.TryParse(input, out hours))
                        {
                            //Ends loop if conditions are met
                            distanceLoop1 = true;
                            distanceLoop2 = true;
                            Console.WriteLine("\nPress enter to continue..");
                        }
                        else
                        {
                            //Display invalid option to user
                            Console.WriteLine(DistanceLibrary.StandardMessages.DisplayInvalidOption());
                            Console.ReadLine();
                        }
                        //Clear current screen
                        Console.Clear();

                    } while (distanceLoop2 == false);

                }
                else
                {
                    //Display invalid option to user
                    Console.WriteLine(DistanceLibrary.StandardMessages.DisplayInvalidOption());
                    Console.ReadLine();
                }
                //Clear current screen
                Console.Clear();
            } while (distanceLoop1 == false);
        }
    }
}
