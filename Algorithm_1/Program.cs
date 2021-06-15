using System;

namespace Algorithm_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] startingArr = { 1, 2, 3, 4 };
            string input;
            int k;
            // Keep asking for an integer until successful input.
            do
            {
                Console.WriteLine("Input an integer and press Enter.");
                input = Console.ReadLine();
                if (!int.TryParse(input, out k))
                    Console.WriteLine("Wrong input type, must be an integer.");
            } while (!int.TryParse(input, out _));
            Console.WriteLine("Starting array [{0}]", string.Join(", ", startingArr));
            Console.WriteLine("Result array [{0}]", string.Join(", ", shiftArray(k)));

            // Iterate over the array and use module to get new indexes for values.
            // Using module makes sure that there are no 'out of bounds' errors.
            int[] shiftArray(int k)
            {
                int[] resultArr = new int[startingArr.Length];
                for (int i = 0; i < startingArr.Length; i++)
                {
                    resultArr[i] = startingArr[(i + k) % startingArr.Length];
                }
                return resultArr;
            }
        }
    }
}
