using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class GetString
    {
        public static void GetSentenceFromUser(ref string sentence, ref string[] token)
        {
            Console.Clear();
            //Get string from user and tokenize it by delimitters
            Console.WriteLine(WordLibrary.StandardMessages.DisplayEnterWordsTitle());
            Console.Write(WordLibrary.StandardMessages.DisplayEnterWords());
            sentence = Console.ReadLine();
            //Tokenize string and split into an array
            token = sentence.Split(' ', '.', '\n', '\t', '!', '?');
            foreach (var e in token)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
            Console.WriteLine(WordLibrary.StandardMessages.DisplayPressEnter());
        }
    }
}
