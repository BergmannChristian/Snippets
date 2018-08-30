using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pig_Latinizer
{
    class The_Pig_Latinizer
    {
        static void Main(string[] args)
        {
            ///Pig Latinizer

            //Variable Declaration : One to hold the user input string, one to hold the modified string.
            string name, modifiedName;

            //Target data : Accept user input, de-capitalize the string and remove any whitespace.
            name = Console.ReadLine().ToLower().Trim();

            //Algorithm : If statement determines whether or not the word is only a single letter
            if(name.Length > 1)
            {
                //               Second letter, capitalized       Every letter after the second          First letter        ay
                modifiedName = name.Substring(1, 1).ToUpper() + name.Substring(2, name.Length - 2) + name.Substring(0, 1) + "ay";
            }
            else
            {
                //If there is only one letter, capitalize it and add ay to the end of it.
                modifiedName = name.ToUpper() + "ay";
            }
            
            //Result Display
            Console.WriteLine("Your name in Pig Latin: {0}", modifiedName);
            Console.ReadLine();

            ///End Pig Latinizer
        }
    }
}
