using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;
namespace ConsoleUI
{
    public class PlayerLogin
    {
        public static void VerifyPlayerUserNamePassword(ref Character player, ref bool playerPassVer)
        {
            Console.Clear();
            string inputName = "";
            string inputPass = "";
            Console.WriteLine("***************************************");
            Console.Write("Enter User Name --> ");
            inputName = Console.ReadLine();
            Console.Write("Enter User Password --> ");
            inputPass = Console.ReadLine();
            if (inputName == player.Name && inputPass == player.PlayerPassword)
            {
                Console.WriteLine("User Name and Password Verified. Press Enter!");               
                
                playerPassVer = true;
            }
            else if(inputName == player.PlayerPassword && inputPass != player.Name)
            {
                Console.WriteLine("Password does not match User Name! Press Enter!");
            }
            else if (inputName != player.PlayerPassword && inputPass == player.Name)
            {
                Console.WriteLine("Invalid User Name! Press Enter!");
            }
            else
            {
                Console.WriteLine("Invalid User Name and Password! Press Enter!");
            }
            Console.ReadLine();

        }
    }
}
