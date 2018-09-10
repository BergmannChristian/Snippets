using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc_Calculations
{
    class Program
    {

        const string LINE = "____________________________________________________";

        static void Main(string[] args)
        {

            int mathMode;

            Console.WriteLine("Enter 1 for the Pythagorean theorem\n{0}", LINE);

            mathMode = Int32.Parse(Console.ReadLine());

            if (mathMode == 1)
            {
                Console.Clear();
                PythagoreanTheorem();
            }

            Console.ReadLine();

        }

        static public void PythagoreanTheorem()
        {
         
            double a, b, c, result;

            Console.WriteLine("Please enter values for A\u00b2, B\u00b2, and C\u00b2.\nThe number 0.0 should be entered for the side that we are solving for.\n(e.x. a = 6, b = 4, c = 0.0)");

            //Record values for each variable.
            Console.WriteLine("\nA\u00b2=");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("B\u00b2=");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("C\u00b2=");
            c = double.Parse(Console.ReadLine());

            if (a == 0.0)
            {
                result = Math.Round(Math.Sqrt(((c * c) - (b * b))),1);

                Console.WriteLine("\nExplanation " +
                    "\n{0} " +
                    "\n{1}\u00b2 - {2}\u00b2 = a" +
                    "\n{3} - {4} = \u221A{5}" +
                    "\na = {6}", LINE, c, b, c * c, b * b, result*result, result);
            }
            else if (b == 0.0)
            {
                result = Math.Round(Math.Sqrt(((c * c) - (a * a))),1);

                Console.WriteLine("\nExplanation " +
                    "\n{0} " +
                    "\n{1}\u00b2 - {2}\u00b2 = a" +
                    "\n{3} - {4} = \u221A{5}" +
                    "\nb = {6}", LINE, c, a, c * c, a * a, result*result, result);
            }
            else if (c == 0.0)
            {
                result = Math.Round(Math.Sqrt(((a * a) + (b * b))),1);

                Console.WriteLine("\nExplanation " +
                    "\n{0} " +
                    "\n{1}\u00b2 + {2}\u00b2 = a" +
                    "\n{3} + {4} = \u221A{5}" +
                    "\nc = {6}", LINE, a, b, a * a, b * b, result*result, result);
            }
            else
            {
                Console.WriteLine("ERROR");
            }

        }

    }
}
