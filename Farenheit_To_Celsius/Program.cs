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

            //Declare variables
            int farenheit;
            double celsius;

            //Store the user input
            farenheit = Int32.Parse(Console.ReadLine());

            //Convert the user input using the farenheit celsius conversion formula.
            celsius = Math.Round(5 * ( (double) farenheit - 32) / 9, 1);

            //Print result to console.
            Console.WriteLine("{0} Farenheit = {1} Celsius", farenheit, celsius);
            Console.ReadLine();

        }
    }
}
