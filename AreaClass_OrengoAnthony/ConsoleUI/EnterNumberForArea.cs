using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class EnterNumberForArea
    {
        public static void GetRectangleLengthWidth(ref int length, ref int width)
        {
            //Clear current screen
            Console.Clear();
            string input;
            bool loopLength = false;
            bool loopWidth = false;
            
            //loop to control user input
            do
            {
                Console.WriteLine(AreaLibrary.StandardMessages.DisplayRectangleTitle());
                //Get input from user
                Console.Write("Enter Rectangle Length --> ");
                input = Console.ReadLine();                
                //Determine if input is a number or letter
                if (int.TryParse(input, out length))
                {
                    //loop to control user input
                    do
                    {
                        //Get input from user
                        Console.Write("Enter Rectangle Width --> ");
                        input = Console.ReadLine();
                        //Determine if input is a number or letter
                        if (int.TryParse(input, out width))
                        {
                            //End loops if input is a number
                            loopWidth = true;
                            loopLength = true;
                        }
                        else
                        {
                            //Displays invalid input if character is not a number
                            Console.WriteLine(AreaLibrary.StandardMessages.DisplayInvalidInput());
                            Console.WriteLine(AreaLibrary.StandardMessages.DisplayPressEnter());
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(AreaLibrary.StandardMessages.DisplayRectangleTitle());
                        }
                    } while (loopWidth == false);                   
                }               
                else
                {
                    //Displays invalid input if character is not a number
                    Console.WriteLine(AreaLibrary.StandardMessages.DisplayInvalidInput());
                    Console.WriteLine(AreaLibrary.StandardMessages.DisplayPressEnter());
                    Console.ReadLine();
                    Console.Clear();                    
                }
            } while (loopLength == false);              
            //Sends length and width to method in Area class to be calculated and returned
            Console.WriteLine("Rectangle Area: "+ AreaLibrary.Area.CalculateArea(length, width));
            //Displays answer to user
            Console.WriteLine(AreaLibrary.StandardMessages.DisplayPressEnter());
            Console.ReadLine();
        }
        public static void GetCircleRadius(ref double circleRadius)
        {
            Console.Clear();
            bool loopCircle = false;
            string input;

            //loop to control user input
            do
            {
                Console.WriteLine(AreaLibrary.StandardMessages.DisplayCircleTitle());
                //Get input from user
                Console.Write("Enter Circle Radius --> ");
                input = Console.ReadLine();
                //Determine if input is a number or letter
                if (double.TryParse(input, out circleRadius))
                {
                    //End loops if input is a number
                    loopCircle = true;
                }
                else
                {
                    //Displays invalid input if character is not a number
                    Console.WriteLine(AreaLibrary.StandardMessages.DisplayInvalidInput());
                    Console.WriteLine(AreaLibrary.StandardMessages.DisplayPressEnter());
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (loopCircle == false);            
            //Sends circleRadius to method in Area class to be calculated and returned
            Console.WriteLine("Circle Area: " + AreaLibrary.Area.CalculateArea(circleRadius));
            //Displays answer to user
            Console.WriteLine(AreaLibrary.StandardMessages.DisplayPressEnter());
            Console.ReadLine();
        }

        public static void GetCylinderRadiusAndHeight(ref double radius, ref double height)
        {
            Console.Clear();
            bool loopRadius = false;
            bool loopHeight = false;
            string input;

            //loop to control user input
            do
            {
                Console.WriteLine(AreaLibrary.StandardMessages.DisplayCylinderTitle());
                //Get input from user
                Console.Write("Enter cylinder radius --> ");
                input = Console.ReadLine();
                //Determine if input is a number or letter
                if (double.TryParse(input, out radius))
                {
                    //loop to control user input
                    do
                    {
                        //Get input from user
                        Console.Write("Enter cylinder height --> ");
                        input = Console.ReadLine();
                        //Determine if input is a number or letter
                        if (double.TryParse(input, out height))
                        {
                            loopHeight = true;
                            loopRadius = true;
                        }
                        else
                        {
                            //Displays invalid input if character is not a number
                            Console.WriteLine(AreaLibrary.StandardMessages.DisplayInvalidInput());
                            Console.WriteLine(AreaLibrary.StandardMessages.DisplayPressEnter());
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(AreaLibrary.StandardMessages.DisplayCylinderTitle());
                        }

                    } while (loopHeight == false);                    
                }
                else
                {
                    //Displays invalid input if character is not a number
                    Console.WriteLine(AreaLibrary.StandardMessages.DisplayInvalidInput());
                    Console.WriteLine(AreaLibrary.StandardMessages.DisplayPressEnter());
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (loopRadius == false);            
            //Sends radius and height to method in Area class to be calculated and returned
            Console.WriteLine("Cylinder Area: " + AreaLibrary.Area.CalculateArea(radius, height));
            //Displays answer to user
            Console.WriteLine(AreaLibrary.StandardMessages.DisplayPressEnter());
            Console.ReadLine();
        }        
    }
}
