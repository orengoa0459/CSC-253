using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleUI
{
    public static class TextDocument
    {
        public static void CreateTextDocument(ref StreamWriter outputFile, ref string dir,bool loop, ref string documentName, ConsoleKeyInfo keyboard)
        {
            string input;
            //Clear current screen
            Console.Clear();            
            do
            {
                Console.Clear();
                //Display menu options to user
                Console.WriteLine(DistanceLibrary.StandardMessages.DisplayDocumentMenu());
                //Get input from user
                keyboard = Console.ReadKey();
                switch (keyboard.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        //Allows user to create document and is verified for currect file format
                        DocumentCreationVerification.VerifyCreatedDocument(ref outputFile, ref  dir, loop,  ref documentName,keyboard);
                        loop = true;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        Console.WriteLine(DistanceLibrary.StandardMessages.DisplayDocumentNameTitle());
                        //Allows user to user pre existing document from the documents folder   
                        Console.WriteLine("\nInput Document Name without .txt");
                        input = Console.ReadLine();
                        documentName = input;
                        loop = true;
                        break;
                    case ConsoleKey.Escape:
                        //Ends menu loop and returns to main menu
                        loop = true;
                        break;
                    default:
                        //Display invalid selection
                        Console.WriteLine(DistanceLibrary.StandardMessages.DisplayInvalidOption());
                        Console.ReadLine();
                        break;
                }         
            } while (loop == false);
        }
    }
}
