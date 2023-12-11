/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: 3.ACIF
 *--------------------------------------------------------------
 *              Daniel Binder, 05.12.2023
 *--------------------------------------------------------------
 * Description:
 * ...
 *--------------------------------------------------------------
*/

using System;

namespace FindAllBits
{
    public class Program
    {
        public static void Main()
        {
            string input = null;
            bool valideNumber;
            uint number,
                bit;
            double bitValue,
                bitResult = 0;

            do
            {
                // Input
                Console.Write(
                    "Geben Sie eine Zahl zwischen 1 und {0} ein (0 für Ende): ",
                    UInt32.MaxValue
                );
                input = Console.ReadLine();

                // Processing
                valideNumber = uint.TryParse(input, out number);
                for (int i = 0; valideNumber && number > 0; ++i)
                {
                    bit = number % 2;
                    number /= 2;
                    Console.Write("{0} x 2^{1}", bit, i);
                    if (bit != 0)
                    {
                        bitValue = Math.Pow(2, i);
                        bitResult += bitValue;
                        Console.WriteLine(" = {0}", bitValue);
                    }
                    else
                        Console.WriteLine();
                }
                if (input != "0")
                {
                    // Output
                    Console.WriteLine("===========================");
                    Console.WriteLine("Dezimalzahl: {0}", input);
                    Console.WriteLine("Summe aller Bitwerte: {0}", bitResult);
                    Console.WriteLine("===========================");
                    Console.WriteLine();
                    bitResult = 0;
                }
            } while (input != "0");
        }
    }
}
