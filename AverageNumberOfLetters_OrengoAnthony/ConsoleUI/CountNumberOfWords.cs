using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class CountNumberOfWords
    {
        public static void CountWords(ref string sentence, ref string[] token)
        {
            Console.Clear();
            //Display number of words to user
            Console.WriteLine(WordLibrary.StandardMessages.DisplayAverageLettersTitle());
            Console.WriteLine($"Number of Words: {token.Length}");                       
        }

        public static void CountNumberOfLetters(ref string sentence, ref int lengthLetters)
        {
            //Calculate number of letters and display to the user
            int x = 0;
            lengthLetters = 0;
            while (x <= sentence.Length - 1)
            {
                if (sentence[x] == ' ' || sentence[x] == '\n' || sentence[x] == '\t')
                {

                }
                else
                {
                    lengthLetters++;
                }
                x++;
            }            
            Console.WriteLine($"Total Letters: {lengthLetters}");
        }

        public static void GetAverageLetters(ref string sentence, ref string[] token, ref int lengthLetters)
        {
            //Calculate the average number of letters in each word
            int averageLetters;
            averageLetters = lengthLetters / token.Length;           
            Console.WriteLine($"\nAverage Letters:  {averageLetters}");
            Console.WriteLine(WordLibrary.StandardMessages.DisplayPressEnter());
        }
    }
}
