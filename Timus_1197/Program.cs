using System;

namespace Timus_1197
{
    public class Program
    {
        public static void Main()
        {
            // Array with results; first dimention - board numbers; second - letters
            short[,] arrNumOfMoves = { { 2, 3, 4, 4, 4, 4, 3, 2 }, 
                                       { 3, 4, 6, 6, 6, 6, 4, 3 },
                                       { 4, 6, 8, 8, 8, 8, 6, 4 },
                                       { 4, 6, 8, 8, 8, 8, 6, 4 },
                                       { 4, 6, 8, 8, 8, 8, 6, 4 },
                                       { 4, 6, 8, 8, 8, 8, 6, 4 },
                                       { 3, 4, 6, 6, 6, 6, 4, 3 },
                                       { 2, 3, 4, 4, 4, 4, 3, 2 } };

            // ---=== Read the Input Data ===---
            // Read the number of input lines
            int numInput = Int32.Parse(Console.ReadLine());
            // Read input into arrInput
            string[] arrInput = new string[numInput];
            for (int i = 0; i < numInput; ++i)
            {
                arrInput[i] = Console.ReadLine();
            }

            // Bottom left corner of the board has label a1
            foreach (string position in arrInput)
            {
                // Get row number; -1 because array index starts with 0
                int i = Int32.Parse(position[1].ToString()) - 1;
                // Get column number: 'b' - 'a' = 1
                int j = position[0] - 'a';

                Console.WriteLine(arrNumOfMoves[i, j]);
            }
        }
    }
}
