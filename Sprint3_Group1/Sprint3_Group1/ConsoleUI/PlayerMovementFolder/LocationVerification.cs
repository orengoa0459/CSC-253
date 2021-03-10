using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;
namespace ConsoleUI.PlayerMovementFolder
{
    public class LocationVerification
    {
        public static void DisplayPlayerMovementOptions(string input, ref int locOne, ref int locTwo, ref string[,] map1)
        {
            #region Location/Player Movement Options Map1
            //START POINT-----------------------------------------------------
            Console.ForegroundColor = ConsoleColor.White;
            if (locOne == 1 && locTwo == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Movement Options: Go South");
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (locOne == 2 && locTwo == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Movement Options: Go East");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (locOne == 2 && locTwo == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Movement Options: Go East; Go West;");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (locOne == 2 && locTwo == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Movement Options: Go North; Go South; Go East; Go West");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (locOne == 1 && locTwo == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Movement Options: Go South; Go East; ");
                Console.ForegroundColor = ConsoleColor.White;
            }

            else if (locOne == 1 && locTwo == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Movement Options: Go South;Go East; Go West");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (locOne == 1 && locTwo == 4)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Movement Options: Go South; Go West");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (locOne == 2 && locTwo == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Movement Options: Go North; Go South; Go East; Go West");
                Console.ForegroundColor = ConsoleColor.White;
            }

            else if (locOne == 2 && locTwo == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Movement Options: Go North; Go South; Go East; Go West");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (locOne == 2 && locTwo == 4)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Movement Options: Go North; Go South; Go East; Go West");
                Console.ForegroundColor = ConsoleColor.White;
            }           

            else if (locOne == 3 && locTwo == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Movement Options: Go North; Go East;");
                Console.ForegroundColor = ConsoleColor.White;
            }

            else if (locOne == 3 && locTwo == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Movement Options: Go North; Go East; Go West");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (locOne == 3 && locTwo == 4)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Movement Options: Go North; Go West");
                Console.ForegroundColor = ConsoleColor.White;
            }
            //Exit Map1--------------------------------
            else if (locOne == 2 && locTwo == 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Movement Options: Go East; Go West");
                Console.ForegroundColor = ConsoleColor.White;
            }




            #endregion
        }
    }
}
