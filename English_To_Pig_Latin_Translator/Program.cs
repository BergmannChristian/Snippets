using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_To_Pig_Latin_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine().ToLower();

            string[] separatedInput = userInput.Split(' ');
            string modifiedSentence = "";

            foreach (string word in separatedInput)
            {
                modifiedSentence = modifiedSentence + Translator(word) + " ";
            }

            modifiedSentence = modifiedSentence.Substring(0, 1).ToUpper() + modifiedSentence.Substring(1, modifiedSentence.Length - 2) + ".";

            Console.WriteLine(modifiedSentence);

            Console.ReadLine();
        }

        static public string Translator (string word)
        {
            if (word.Length < 2)
            {
                return word + "ay";
            }
            else
            {
                return word.Substring(1, 1) + word.Substring(2, word.Length - 2) + word.Substring(0, 1) + "ay";
            }
        }


    }
}
