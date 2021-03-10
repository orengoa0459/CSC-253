 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class CalculateDistance
    {
        public static void CalculateVehiclesDistance(ref double speed,ref double hours,ref double distance,bool distanceLoop,ref string input)
        {
            //Clear current screen
            Console.Clear();
            //Calculate distance traveled and display to the user
            distance = speed * hours;
            //Display final results to user
            Console.WriteLine(DistanceLibrary.StandardMessages.DisplayFinalResultTitle());
            Console.WriteLine($"\nVehicle Speed: {speed}\nTravel Time: {hours}\n\nYour vehicle traveled {distance} miles.");
            Console.WriteLine(DistanceLibrary.StandardMessages.DisplayPressEnter());
            Console.ReadLine();
        }
    }
}
