using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleUI
{
    public static class DocumentCreationVerification
    {
        public static void VerifyCreatedDocument(ref StreamWriter outputFile, ref string dir, bool loop, ref string documentName, ConsoleKeyInfo keyboard)
        {
            Console.Clear();
            //Display document creation instructions to user
            Console.WriteLine(DistanceLibrary.StandardMessages.DisplayDocumentInstructions());
            Console.ReadLine();
            Console.Clear();
            do
            {
                //Display title to user
                Console.WriteLine(DistanceLibrary.StandardMessages.DisplayDocumentCreationTitle());
                //Get document name from user
                Console.Write("Enter name of file: ");
                documentName = Console.ReadLine();

                //Verify the document is correctly named start -----------------------------------------------------------
                if (documentName.Contains(".txt"))
                {
                    Console.WriteLine("Invalid document name! You can not use .txt in your file name!\n\n" +
                        "Press Enter and Try Again!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (documentName.Contains("<"))
                {
                    Console.WriteLine("Invalid document name! You can not use < in your file name!\n\n" +
                        "Press Enter and Try Again!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(documentName.Contains(">"))
                {
                    Console.WriteLine("Invalid document name! You can not use > in your file name!\n\n" +
                        "Press Enter and Try Again!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (documentName.Contains(":"))
                {
                    Console.WriteLine("Invalid document name! You can not use : in your file name!\n\n" +
                        "Press Enter and Try Again!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (documentName.Contains(@""""))
                {
                    Console.WriteLine(@"Invalid document name! You can not use "" in your file name!\n\n" +
                        "Press Enter and Try Again!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (documentName.Contains("/"))
                {
                    Console.WriteLine("Invalid document name! You can not use / in your file name!\n\n" +
                        "Press Enter and Try Again!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (documentName.Contains(@"\"))
                {
                    Console.WriteLine(@"Invalid document name! You can not use \ in your file name!" +
                        "\n\nPress Enter and Try Again!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (documentName.Contains("|"))
                {
                    Console.WriteLine("Invalid document name! You can not use | in your file name!\n\n" +
                        "Press Enter and Try Again!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (documentName.Contains("?"))
                {
                    Console.WriteLine("Invalid document name! You can not use ? in your file name!\n\n" +
                        "Press Enter and Try Again!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (documentName.Contains("*"))
                {
                    Console.WriteLine("Invalid document name! You can not use * in your file name!\n\n" +
                        "Press Enter and Try Again!");
                    Console.ReadLine();
                    Console.Clear();
                }
                //Verify the document is correctly named end==================================================

                //Creates document if the name passes verification
                else
                {
                    try
                    {

                        outputFile = File.CreateText($@"{dir}\DistanceDocuments\{documentName}.txt");
                        outputFile.Write("Distance Program Data\n*********************\n\n");
                        outputFile.Close();

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    Console.WriteLine("\n***File Created");
                    Console.Write("\nYour file is located in: " + $@"{dir}\DistanceDocuments\{documentName}.txt" +
                        "\n\nPress Enter to Continue...");
                    Console.ReadLine();
                    loop = true;
                }
                
            } while (loop == false);
            

        }
    }
}
