using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordLibrary;
namespace ConsoleUI
{
    public class DetermineFrequentLetter
    {
        public static void DetermineTheFrequentCharacter(ref string input)
        {
            Console.Clear();
            // Declare and initialize array for aschii characters
            int[] aschiiCharacters = new int[256];
            
            //Count each character in the string 
            for (int i = 0; i < input.Length; i++)
            {
                aschiiCharacters[input[i]]++;               
            }
            //Base counter for character that appears the most
            int count = -1;
            char letter = ' ';
            //Determine which letter appears the most in the string
            for (int i = 0; i < input.Length; i++)
            {
                if (count < aschiiCharacters[input[i]])
                {
                    count = aschiiCharacters[input[i]];
                    letter = input[i];
                }
            }
            //Display results to user
            Console.WriteLine(WordLibrary.StandardMessages.DisplayResults());
            Console.WriteLine(WordLibrary.StandardMessages.DisplayFrequentLetter(input, letter, count));            
            Console.ReadLine();

        }
    }
}
