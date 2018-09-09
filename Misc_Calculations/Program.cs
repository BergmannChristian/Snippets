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
                PythagoreanTheorem();
            }
            Console.ReadLine();
        }

        static public void PythagoreanTheorem()
        {
            char mode;
            double a, b, c;

            Console.WriteLine("Are we solving for a, b, or c?");

            mode = char.Parse(Console.ReadLine());

            if (mode == 'a')
            {
                Console.WriteLine("\nFormula: c\u00b2 - b\u00b2 = a\u00b2");

                Console.WriteLine("c =");
                c = Int32.Parse(Console.ReadLine());

                Console.WriteLine("b =");
                b = Int32.Parse(Console.ReadLine());

                a = Math.Round(Math.Sqrt(((c * c) - (b * b))), 2);

                Console.WriteLine("a = {0}", a);
            }
            else if (mode == 'b')
            {
                Console.WriteLine("\nFormula: c\u00b2 - a\u00b2 = b\u00b2");

                Console.WriteLine("c =");
                c = Int32.Parse(Console.ReadLine());

                Console.WriteLine("a =");
                a = Int32.Parse(Console.ReadLine());

                b = Math.Round(Math.Sqrt(((c * c) - (a * a))), 2);

                Console.WriteLine("b = {0}", b);
            }
            else if (mode == 'c')
            {
                Console.WriteLine("\nFormula: a\u00b2 + b\u00b2 = c\u00b2");

                Console.WriteLine("a =");
                a = Int32.Parse(Console.ReadLine());

                Console.WriteLine("b =");
                b = Int32.Parse(Console.ReadLine());

                c = Math.Round(Math.Sqrt(((a * a) + (b * b))), 2);

                Console.WriteLine("c = {0}", c);
            }


            /*
            int a, b;
            double c;

            Console.WriteLine("\nFormula: a\u00b2 + b\u00b2 = c\u00b2");

            Console.WriteLine("Value for a");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Value for b");
            b = Int32.Parse(Console.ReadLine());

            c = Math.Round(Math.Sqrt(((a * a) + (b * b))), 2);

            Console.WriteLine(c);
            Console.ReadLine();
            */
        }

    }
}
