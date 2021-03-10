using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;
using System.IO;
namespace ConsoleUI.PlayerDocuments
{
    public class PlayerData
    {
        public static void AddPlayerDataToDocument(ref Character player)
        {
            StreamWriter output;
            
            try
            {
                using (output = File.AppendText("PlayerData.csv"))
                {
                    output.WriteLine(player.Name + "," + player.PlayerRace + "," + player.PlayerClass + "," +
                     player.HealthPoints + "," + player.PlayerPassword + "," + player.Coins + "," + player.Potion);
                }
                


                //output.Close();

            }
            
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }

        }
    }
}
