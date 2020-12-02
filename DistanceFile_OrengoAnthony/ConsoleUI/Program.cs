using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
* Date 09.25.2020
* CSC 153
* Anthony Orengo
* Program description: The Travel Distance Program allows the user to input specific travel data (Speed/Time),
* and then calculates the total distance traveled. The user must follow the steps below in order
* to save the outputted data to a document.
*/
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize variables
            string input = "";
            string documentName = "";  
            double speed = 0.0;
            double hours = 0.0;
            double distance = 0.0;
            //Declare and initialize sentinel
            bool menuLoop = false;
            //Gets directory and path location for the text documents
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            /*Create StreamWriter class using default document
             * The default document is used as a referencing parameter
             * The default document will be created and overwritten each time the program starts.*/
            StreamWriter outputFile = new StreamWriter(dir + @"\DistanceDocuments\DefaultDoc.txt"); 

            //Create keyboard object
            ConsoleKeyInfo keyboard = new ConsoleKeyInfo();

            //Display Welcome Screen
            Console.WriteLine(DistanceLibrary.StandardMessages.DisplayWelcomeMessage());
            Console.ReadLine();
            //CLears current screen
            Console.Clear();
            //Display program instructions
            Console.WriteLine(DistanceLibrary.StandardMessages.DisplayProgramInstructions());
            Console.ReadLine();
            Console.Clear();

            do
            {
                //Display main menu
                Console.WriteLine(DistanceLibrary.StandardMessages.DisplayMainMenu());
                //get user input
                keyboard = Console.ReadKey();
                switch (keyboard.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        //Create text doc
                        TextDocument.CreateTextDocument(ref outputFile,ref dir, menuLoop, ref documentName, keyboard);                        
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        //Calculate vehicle distance
                        GetTravelData.GetSpeedAndTime(ref speed, ref hours, ref distance, menuLoop, ref input);
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        //Write to text document
                        CalculateDistance.CalculateVehiclesDistance(ref speed, ref hours, ref distance, menuLoop,ref outputFile,ref dir, ref documentName, keyboard);
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        //Displays current document
                        Console.Clear();
                        Console.WriteLine(DistanceLibrary.StandardMessages.DisplayCurrentDocumentTitle());
                        Console.WriteLine($@"{dir}\DistanceDocuments\{documentName}.txt" + "\nPress Enter...");
                        Console.ReadLine();
                        break;
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