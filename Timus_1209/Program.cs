using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timus_1209
{
    public class Program
    {
        public static void Main()
        {
            // Read input
            // Read N
            int N = Int32.Parse(Console.ReadLine());

            // Create an array to store the output data
            // It is cheaper to store the output data because we can use bool instead of long
            // to store the data
            bool[] output = new bool[N];

            // Read data
            // For each input number calculate and store the output
            for (int i = 0; i < N; ++i)
            {
                long tempInput = Int64.Parse(Console.ReadLine());

                // Calculate the output
                output[i] = GetDigitInSequenceByIndex(tempInput);
            }

            // Output the results
            foreach (bool result in output)
            {
                if (result)
                {
                    Console.Write("1" + " ");
                }
                else
                {
                    Console.Write("0" + " ");
                }
            }
        }

        /// <summary>
        /// Returns the digit in the sequence that has the specified index.
        /// TRUE - 1; FALSE - 0.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
 
        public static bool GetDigitInSequenceByIndex(long index)
        {
            long nextNumberLength = 1;
            long testIndex = index;

            while (true)
            {
                if (testIndex < nextNumberLength)
                {
                    return (testIndex == 1);
                }
                else
                {
                    testIndex -= nextNumberLength;
                }

                ++nextNumberLength;
            }
        }

    }
}
