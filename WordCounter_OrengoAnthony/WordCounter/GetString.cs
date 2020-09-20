using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    public static class GetString
    {
        public static void GetSentenceFromUser(ref string sentence, ref string[] words)
        {
            //Clear screen
            Console.Clear();
            Console.WriteLine(WordLibrary.StandardMessages.DisplayEnterWordsTitle());
            Console.Write(WordLibrary.StandardMessages.DisplayEnterWords());
            //Get string from user
            sentence = Console.ReadLine();
            //Tokenize user input by separating words by delimitters
            words = sentence.Split(' ', '.', ',','!','\n','?');            
            Console.WriteLine(WordLibrary.StandardMessages.DisplayPressEnter());            
        }
    }
}
