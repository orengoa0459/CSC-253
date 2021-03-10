using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;
namespace ConsoleUI
{
    public class PlayerStats
    {
        public static void DisplayPlayerStats(ref Character player)
        {
            Console.WriteLine($"****************************************\n"+
                              $"* Player Status                        *\n"+
                              $"****************************************\n"+
                              $"Name: {player.Name} Coins: {player.Coins} \n" +
                              $"Class: {player.PlayerClass} Race: {player.PlayerRace}\n" +
                              $"Health: {player.HealthPoints}\n" +
                              $"Potion: {player.Potion}\n" +
                              $"***************************************\n");
                              
        }
    }
}
