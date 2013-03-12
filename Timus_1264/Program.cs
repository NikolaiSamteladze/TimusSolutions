using System;

namespace Timus_1264
{
    public class Program
    {
        public static void Main()
        {
            // Read input
            string[] data = Console.ReadLine().Split(' ');

            // Parse the input
            long n = Int64.Parse(data[0]);
            long m = Int64.Parse(data[1]);

            Console.WriteLine(n * (m + 1));
        }
    }
}
