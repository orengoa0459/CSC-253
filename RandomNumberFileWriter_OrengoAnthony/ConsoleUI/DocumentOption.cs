using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleUI
{
    public class DocumentOption
    {
        //WRITES TO NEW DOCUMENT///////////////////////////////////////
        public static void WriteToNewDocument(ref int numbers, ref string documentName, ref string directory, Random rand, ConsoleKeyInfo keyboard,DateTime now)
        {
            //Clears current screen
            Console.Clear();     
            //Catch exception if error occurs during file creation
            try
            {
                //Get document name from user
                Console.Write(FileWriterLibrary.StandardMessages.DisplayEnterNewDocumentName()); 
                documentName = Console.ReadLine();         
                //Determine if file exist in location
                if (File.Exists($@"{directory}\Documents\{documentName}.txt"))
                { 
                    Console.WriteLine("Error! This file exist already!");
                }
                else
                {
                    //Create streamwriter file(Includes directory path)
                    StreamWriter writeNew = File.CreateText($@"{directory}\Documents\{documentName}.txt");
                    Console.WriteLine("\nThe following numbers will be written to:\n" +
                    $"\nFile: {directory}/{documentName}.txt");
                    writeNew.WriteLine("Random Number List\n" +
                        "********************************");
                    writeNew.WriteLine($"Date/Time Created: {now.ToString("F")}");
                    for (int i = 0; i < numbers; i++)
                    {
                        int randomNumber = 0;
                        FileWriterLibrary.GenerateRandomNumber.RandomNumber(ref randomNumber, rand);
                        Console.WriteLine(randomNumber);
                        writeNew.WriteLine(randomNumber);
                    }
                    Console.WriteLine("\nData has been successfully written to document.\n" +
                    "\nPress Enter to continue...");
                    writeNew.Close();
                }                 
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("\n****WRITE ERROR\n****Data was not successfully written to file!\n\n" +
                    "Ensure you do not include the following characters when creating a\n" +
                    "document name." +
                    "\n\n" +
                    "Invalid Character List:\n" +
                    ".txt\n" +
                   "< (less than)\n" +
                   "> (greater than)\n" +
                   ": (colon)\n" +
                  @""" (double quote)" +
                   "\n/ (forward slash)\n" +
                  @"\ (backslash)" +
                   "\n| (vertical bar or pipe)\n" +
                   "? (question mark)\n" +
                   "*(asterisk)\n" +
                   "*****************************\n" +
                   "Press Enter...");
            }
            
            Console.ReadLine();
        }
        //WRITES TO EXISTING DOCUMENT///////////////////////////////////////
        public static void WriteToExistingDocument(ref int numbers, ref string documentName, ref string directory, Random rand,  ConsoleKeyInfo keyboard, DateTime now)
        {
            Console.Clear();
            //Catch exception if error occurs during appending the file 
            try
            {
                Console.Write(FileWriterLibrary.StandardMessages.DisplayEnterExistingDocumentName());
                documentName = Console.ReadLine();
                StreamWriter writeExisting = File.AppendText($@"{directory}\Documents\{documentName}.txt");
                Console.WriteLine("\nThe following numbers will be written to:\n" +
                    $@"\nFile: {directory}\Documents\{documentName}.txt");
                writeExisting.WriteLine("*************************\n" +
                    "Appended File\n" +
                    $"Date/Time Appended: {now.ToString("F")}");
                writeExisting.WriteLine("Random Number List\n" +
                    "*************************");
                for (int i = 0; i < numbers; i++)
                {
                    int randomNumber = 0;
                    FileWriterLibrary.GenerateRandomNumber.RandomNumber(ref randomNumber, rand);
                    Console.WriteLine(randomNumber);
                    writeExisting.WriteLine(randomNumber);                    
                }
                Console.WriteLine("\nData has been successfully written to document.\n" +
                                      "\nPress Enter to continue...");
                writeExisting.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("\n****WRITE ERROR\n****Data was not successfully written to file!\n\n" +
                    "Ensure you do not include the following characters when typing in\n" +
                    "the document name." +
                    "\n\n" +
                    "Invalid Character List:\n" +
                    ".txt\n" +
                   "< (less than)\n" +
                   "> (greater than)\n" +
                   ": (colon)\n" +
                  @""" (double quote)" +
                   "\n/ (forward slash)\n" +
                  @"\ (backslash)" +
                   "\n| (vertical bar or pipe)\n" +
                   "? (question mark)\n" +
                   "*(asterisk)\n" +
                   "*****************************\n" +
                   "Press Enter...");
            }            
            Console.ReadLine();
        }
    }
}
