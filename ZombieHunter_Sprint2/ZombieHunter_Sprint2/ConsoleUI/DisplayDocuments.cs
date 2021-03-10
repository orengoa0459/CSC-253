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
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Error ReadingFile");
                Console.ReadLine();
            }            
        }
        public static void DisplayStartGameMenu()
        {
            string directory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string fileMainMenu = directory + @"\StartGameMenu.txt";
            try
            {
                using (StreamReader outputMainMenu = new StreamReader(fileMainMenu))
                {
                    fileMainMenu = outputMainMenu.ReadToEnd();
                    Console.WriteLine(fileMainMenu);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Error ReadingFile");
                Console.ReadLine();
            }
        }
    }
}
