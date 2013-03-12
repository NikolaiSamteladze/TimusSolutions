using System;

namespace Timus_1313
{
    public class Program
    {
        public static void Main()
        {
            // Read input
            // Read N
            int N = Int16.Parse(Console.ReadLine());
            // Create an array to store the input data
            short[,] arrInputData = new short[N, N];
            // Read data
            for (int i = 0; i < N; ++i)
            {
                string[] inputLineParts = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; ++j)
                {
                    arrInputData[i, j] = Int16.Parse(inputLineParts[j]);
                }
            }

            // Write first N diagonals up to the main diagonal (the main diagonal included)
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j <= i; ++j)
                {
                    Console.Write(arrInputData[i - j, j] + " ");
                }
            }

            // Write the remain N-1 diagonals
            for (int i = 0; i < N - 1; ++i)
            {
                for (int j = N - 1; j > i; --j)
                {
                    Console.Write(arrInputData[j, N + i - j] + " ");
                }
            }

        }
    }
}
