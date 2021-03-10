using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
* Date 03.21.2020
* CSC 153
* Anthony Orengo
* Program description: This program uses a menu to allow the user to create a vehicle,
* by entering the vehicle year, make, and speed. The user will then have an option to 
* increase or decrease the vehicle speed.
*/
namespace ConsoleUI
{
    class Program
    {
        //Access private sets
        public static String Year { get; private set; }
        public static string Make { get; private set; }
        public static int Speed { get; private set; }
        public static CarLibrary.Car car1 = new CarLibrary.Car(Year, Make, Speed);

        static void Main(string[] args)      
        {   
            //Sentinel to control loop
            bool loop = false;
            do
            {
                
                Console.WriteLine(CarLibrary.StandardMessages.CarMenu());
                Console.Write("Select from the menu --> ");
                //Get input from user
                string input;

                input = Console.ReadLine();
                //Switch to direct to proper process
                switch (input)
                {
                    case "1":
                        //Get vehicle information
                        CreateCar(ref input);           
                        break;
                    case "2":
                        //Increases vehicle speed by 5
                        int acc = car1.Speed += 5;
                        Console.Write("\nCurrent vehicle speed: " + acc + "\n " + "\nPress enter to continue.");
                        Console.ReadLine();
                        break;
                    case "3":
                        //Reduces vehicle speed by 5
                        int dec = car1.Speed -=5;
                        Console.Write("\nCurrent vehicle speed: " + dec +"\n " + "\nPress enter to continue.");
                        Console.ReadLine();
                        break;
                    case "4":
                        //Displays vehicle information
                        Console.WriteLine(CarLibrary.StandardMessages.DisplayVehicleInformation(car1.Year, car1.Make, car1.Speed));
                        Console.ReadLine();
                        break;
                    case "5":
                        //Exits program
                        loop = true;
                        Console.WriteLine("Good Bye!");
                        break;
                    default:
                        //Displays invalid choice
                        Console.WriteLine(CarLibrary.StandardMessages.InvalidChoice());
                        Console.WriteLine("Press enter to continue!");
                        Console.ReadLine();
                        
                        break;

                }
                //Clears current screen
                Console.Clear();
            } while (loop == false);
            
            
        }

       public static void CreateCar(ref string input)
        {
            //Get vehicle year from user
            Console.Write(CarLibrary.StandardMessages.EnterYear());
            input = Console.ReadLine();
            Year = input;
            car1.Year = Year;
            //Get vehicle make from user
            Console.Write(CarLibrary.StandardMessages.EnterMake());
            input = Console.ReadLine();
            Make = input;
            car1.Make = Make;
            //Get vehicle speed from user
            Console.Write(CarLibrary.StandardMessages.EnterSpeed());
            input = Console.ReadLine();
            Speed = int.Parse(input);
            car1.Speed = Speed;
        }

      
    }
}

