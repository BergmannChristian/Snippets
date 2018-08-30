using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farenheit_To_Celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Farenheit to Celsius Converter

            //Declare variables
            int farenheit;
            double celsius;

            //Accept user input
            farenheit = Int32.Parse(Console.ReadLine());

            //Perform farenheit to celsius conversion.
            celsius = 5 * ( (double) farenheit - 32) / 9;
            //Round result to nearest tenth.
            celsius = Math.Round(celsius, 1);

            //Display Results
            Console.WriteLine("The temperature is {0}f ({1}c)", farenheit, celsius);
            Console.ReadLine();

            ///End Farenheit to Celsius Converter
        }
    }
}
