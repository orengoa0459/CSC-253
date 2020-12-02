using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleUI
{
    public static class CalculateDistance
    {
        public static void CalculateVehiclesDistance(ref double speed, ref double hours, ref double distance, bool distanceLoop,ref StreamWriter outputFile, ref string dir, ref string documentName, ConsoleKeyInfo keyboard)
        {
            ////Clear current screen
            Console.Clear();            
            Console.WriteLine(DistanceLibrary.StandardMessages.DisplayWriteToDocumentTitle());
            ////Calculate distance traveled and display to the user 
            distance = speed * hours;
            ////Display final results to user
            //Console.WriteLine(DistanceLibrary.StandardMessages.DisplayFinalResultTitle());
            Console.WriteLine($"\nVehicle Speed: {speed}\nTravel Time: {hours}\n\nYour vehicle traveled {distance} miles.");
           // Console.WriteLine(DistanceLibrary.StandardMessages.DisplayPressEnter());

            do
            {
                //Give user the option to write the inputted information to the document displayed below
                Console.WriteLine($"\nDo you wish to add this information to the document below?\n\n" +
                $@"{dir}\DistanceDocuments\{documentName}.txt" +
                $"\n\n1. Yes\n" +
                $"2. No");
                keyboard = Console.ReadKey();
                switch (keyboard.Key)
                {
                    //Writes information to document
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        try
                        {
                            using (outputFile = File.AppendText($@"{dir}\DistanceDocuments\{documentName}.txt"))
                            {
                                outputFile.Write($"\nVehicle Speed: {speed}\nTravel Time: {hours}\n\nYour vehicle traveled {distance} miles.\n");
                                outputFile.Close();
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        Console.Clear();
                        Console.WriteLine("Information written to specified document.\n" +
                            "\nPress Enter...");
                        Console.ReadLine();
                        distanceLoop = true;
                        break;
                        //Does not write the information to the document
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        distanceLoop = true;
                        break;
                    //Returns to main menu
                    case ConsoleKey.Escape:
                        distanceLoop = true;
                        break;
                    default:
                        //Display invalid selection
                        Console.WriteLine(DistanceLibrary.StandardMessages.DisplayInvalidOption());
                        Console.ReadLine();
                        break;
                }
            } while (distanceLoop == false);            
        }
    }
}
