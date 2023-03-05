using System.Diagnostics;

namespace CSharpPerfromance
{
    internal class StringComparision
    {
        public static void RunTest()
        {
            const int N = 10000000;
            string[] strings = new string[N];

            for (int i = 0; i < N; i++)
            {
                strings[i] = Guid.NewGuid().ToString();
            }

            Console.WriteLine($"Comparing {N} strings:");

            // Measure the time taken by the "=" operator
            var stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < N; i++)
            {
                bool isEqual = strings[i] == strings[0];
            }
            stopwatch.Stop();
            Console.WriteLine($"\"=\" operator took {stopwatch.Elapsed.TotalMilliseconds} ms");

            // Measure the time taken by the String.Compare method
            stopwatch.Restart();
            for (int i = 0; i < N; i++)
            {
                int comparison = string.Compare(strings[i], strings[0], StringComparison.OrdinalIgnoreCase);
                bool isEqual = comparison == 0;
            }
            stopwatch.Stop();
            Console.WriteLine($"String.Compare took {stopwatch.Elapsed.TotalMilliseconds} ms");

            // Measure the time taken by the String.Equals method
            stopwatch.Restart();
            for (int i = 0; i < N; i++)
            {
                bool isEqual = string.Equals(strings[i], strings[0]);
            }
            stopwatch.Stop();
            Console.WriteLine($"String.Equals took {stopwatch.Elapsed.TotalMilliseconds} ms");

        }
    }
}
