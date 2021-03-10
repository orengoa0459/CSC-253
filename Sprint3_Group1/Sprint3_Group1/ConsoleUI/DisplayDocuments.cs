using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleUI
{
    public class DisplayDocuments
    {
        #region Display Main Menu
        public static void DisplayMainMenu()
        {
            string directory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string fileMainMenu = directory + @"\MainMenu.txt";
            try
            {
                using (StreamReader outputMainMenu = new StreamReader(fileMainMenu))
                {                    
                    fileMainMenu = outputMainMenu.ReadToEnd();
                    Console.WriteLine(fileMainMenu);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Make a Selection from the Menu--> ");

                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Error ReadingFile");
                Console.ReadLine();
            }            
        }
        #endregion Display Main Menu

        #region Display Start Game Menu
        public static void DisplayStartGameMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            string directory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string fileMainMenu = directory + @"\StartGameMenu.txt";
            try
            {
                using (StreamReader outputMainMenu = new StreamReader(fileMainMenu))
                {
                    fileMainMenu = outputMainMenu.ReadToEnd();
                    Console.WriteLine(fileMainMenu);
                }
                //Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Make a Selection from the Menu--> ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Error ReadingFile");
                Console.ReadLine();
            }
        }
        #endregion  Display Start Game Menu

        #region Display Options Menu
        public static void DisplayOptionsMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            string directory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string fileMainMenu = directory + @"\OptionsMenu.txt";
            try
            {
                using (StreamReader outputMainMenu = new StreamReader(fileMainMenu))
                {
                    fileMainMenu = outputMainMenu.ReadToEnd();
                    Console.WriteLine(fileMainMenu);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Make a Selection from the Menu--> ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Error ReadingFile");
                Console.ReadLine();
            }
        }
        #endregion Display Options Menu

        #region Display Mobs CSV
        public static void DisplayMobs()
        {
            Console.ForegroundColor = ConsoleColor.White;
            string directory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string mobs = directory + @"\Mobs.csv";
            string[] listMobs;
            try
            {
                using (StreamReader outputMainMenu = new StreamReader(mobs))
                {
                    listMobs = File.ReadAllLines(mobs);
                    
                    foreach (string line in listMobs)
                    {
                        if (line.Contains(","))
                        {                           
                            Console.WriteLine(line.Replace(",", " "));
                        }                        
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Make a Selection from the Menu--> ");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Error ReadingFile");
                Console.ReadLine();
            }
        }
        #endregion Display Mobs CSV
    }
}
