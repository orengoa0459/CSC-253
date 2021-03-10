using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailLibrary;

/**
* Date Created: 02.15.2020
* Date Revised: 10.15.2020
* CSC 153
* Anthony Orengo
* Program description: This program determines the retail price
* of an item by calculating the the whole sale cost by the markup percent. 
* The results are then displayed to the user.This program is also menu operated 
* by use of a loop, to be more user friendly.
* 
* Note: This program has been revised and now uses Unit Testing with Xunit.
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {       
            //Create keyboard object
            ConsoleKeyInfo keyboard = new ConsoleKeyInfo();
            //Declare and initialize sentinel 
            bool keep_going = false;            
            do
            {
                //Display main menu
                Console.WriteLine(StandardMessages.DisplayMainMenu());
                keyboard = Console.ReadKey();
                switch (keyboard.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        //Calculate total retail price
                        CalculateRetailPrice.CalculateTotalPrice();
                        break;
                    case ConsoleKey.Escape:
                        //End program
                        keep_going = true;
                        break;
                    default:
                        //Displays invalid option
                        Console.WriteLine(StandardMessages.DisplayInvalidOption());
                        Console.ReadLine();
                        break;
                }               
                Console.Clear();
            } while (keep_going == false);
        }
        

    }
}
