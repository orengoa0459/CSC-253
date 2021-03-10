using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;
namespace ConsoleUI
{
    public class MainGameStart
    {
        public static void StartZombieHunterGame(ref Character player)
        {
            string[,] map1 = new string[5, 5];
            bool moveLoop = false;
            string locationName = "";
            string input ="";
            int locOne = 1;
            int locTwo = 0;
            do
            {

                PlayerStats.DisplayPlayerStats(ref player);                

                Movement.PlayerMovement(ref player,input, ref locOne, ref locTwo, ref map1, ref locationName);

            } while (moveLoop == false);
        }
    }
}
