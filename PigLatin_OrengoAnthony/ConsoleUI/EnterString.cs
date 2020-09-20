using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordLibrary;

namespace ConsoleUI
{
    public class EnterString
    {
        public static void EnterAStringOfWords(ref string input)
        {
            //Clears current screen
            Console.Clear();
            Console.WriteLine(WordLibrary.StandardMessages.DisplayTitle());
            //Get word(s) from user
            Console.Write(WordLibrary.StandardMessages.DisplayEnterWords());
            input = Console.ReadLine();
            input = input.Trim('.', '!','?');
        }
    }
}
