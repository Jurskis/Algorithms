using System;

namespace Algorithm_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArr = new int[] { 2, 3, 9, 9, 2};
            string input;
            int decimalPoint; // Decimal separator index.
            // Keep asking for an integer until successful input.
            do
            {
                Console.WriteLine("Input an integer and press Enter.");
                input = Console.ReadLine();
                if (!int.TryParse(input, out decimalPoint))
                    Console.WriteLine("Wrong input type, must be an integer.");
            } while (!int.TryParse(input, out _));

            Console.WriteLine("Starting number array [{0}]", string.Join(", ", numberArr));
            addOne();
            Console.WriteLine("Result number array [{0}]", string.Join(", ", numberArr));

            void addOne()
            {
                double number = 0.0;
                int fraction = numberArr.Length - decimalPoint; // How many decimals go after decimal point.

                // If decimal separator index is smaller than number array length, then there will be a fraction.
                if(fraction > 0)
                {
                    // Get number from number array.
                    for (int i = 0; i < numberArr.Length; i++)
                        number += Math.Pow(10, (decimalPoint - i - 1)) * numberArr[i];
                    // Add one.
                    number++;
                    // Make sure the are no exes decimals.
                    number = Math.Round(number, fraction);
                    // Turn number back into an array.
                    for (int i = 0; i < numberArr.Length; i++)
                        numberArr[i] = (int)Math.Floor(number / Math.Pow(10, (decimalPoint - i - 1))) % 10;
                        
                }
                // If decimal separator index is mot smaller than number array length, then it's just a whole number.
                else
                {
                    // Get number from number array.
                    for (int i = 0; i < numberArr.Length; i++)
                        number += Math.Pow(10, (numberArr.Length - i - 1)) * numberArr[i];
                    // Add one.
                    number++;
                    // Turn number back into an array.
                    for (int i = 0; i < numberArr.Length; i++)
                        numberArr[i] = (int)Math.Floor(number / Math.Pow(10, (numberArr.Length - i - 1))) % 10;
                }
            }
        }
    }
}
