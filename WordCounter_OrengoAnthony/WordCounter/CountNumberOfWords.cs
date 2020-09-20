using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordLibrary;
namespace WordCounter
{
    public class CountNumberOfWords
    {
        public static void CountWords(ref string sentence, ref string[] words)
        {
            Console.WriteLine(WordLibrary.StandardMessages.DisplayNumberWordsTitle());
            //Display number of words to the user           
            foreach (var element in words)
            {
                Console.WriteLine(element);
            }           
           Console.WriteLine($"Total Words: {words.Length}\n\nPress Enter...");            
        }
    }
}
