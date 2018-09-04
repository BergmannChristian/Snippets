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
         
            List<string> translatedWords = new List<string>();

            bool firstRun = true;
            int indexTracker = 0;

            string targetWord, modifiedWord;

            int firstPoint = 0;
            int secondPoint = 0;

            string userInput = "Love is like an hourglass with the heart filling up as the brain empties".ToLower();
            Console.WriteLine(userInput + "\n");

            foreach (char endPoint in userInput)
            {

                //Determine location of the first whitespace in the string. Assign the value of the indexTracker + one to the firstPoint variable.
                if (endPoint == ' ' && firstRun == true)
                {
                    targetWord = userInput.Substring(0, indexTracker);
                    firstPoint = indexTracker + 1;
                    modifiedWord = Translator(targetWord);

                    translatedWords.Add(modifiedWord + " ");
                    firstRun = false;
                }
                else if (endPoint == ' ')
                {
                    secondPoint = indexTracker - firstPoint;
                    targetWord = userInput.Substring(firstPoint, secondPoint);
                    firstPoint = indexTracker + 1;
                    modifiedWord = Translator(targetWord);

                    translatedWords.Add(modifiedWord + " ");
                }
                else if (indexTracker == userInput.Length - 1)
                {
                    secondPoint = indexTracker - firstPoint;
                    targetWord = userInput.Substring(firstPoint, secondPoint + 1);
                    modifiedWord = Translator(targetWord);

                    translatedWords.Add(modifiedWord + " ");
                }



                indexTracker++;
            }

            string sentence = String.Join(string.Empty, translatedWords.ToArray());

            Console.WriteLine(sentence);

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
