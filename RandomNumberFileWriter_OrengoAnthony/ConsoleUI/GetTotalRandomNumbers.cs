using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class GetTotalRandomNumbers
    {
        public static void GetRandomNumbers(ref int numbers, string input)
        {
            //Set sentinel for number loop
            bool numLoop = false;
            //Clears current screen
            Console.Clear();
            //This loop ensures a number is entered before proceeding to the next step
            do
            {
                //Get total amount of random numbers the user wants
                Console.Write(FileWriterLibrary.StandardMessages.DisplayEnterNumber());
                input = Console.ReadLine();
                //Parse input to prevent program crash
                if (int.TryParse(input, out numbers))
                {
                    //Ends loop
                    numLoop = true;
                }
                else
                {
                    //Displays invalid option
                    Console.WriteLine(FileWriterLibrary.StandardMessages.DisplayInvalidOption());
                    Console.ReadLine();
                }
                //Clears current screen
                Console.Clear();
            } while (numLoop == false);
            
        }
    }
}
