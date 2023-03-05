using System.Diagnostics;

namespace CSharpPerfromance
{
    internal class ExcpetionVsValidation
    {
        public static void RunTest()
        {
            int iterations = 1000;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                // Using exception handling
                try
                {
                    int num = int.Parse("not an integer");
                }
                catch (FormatException)
                {
                    // Ignore the exception
                }
            }

            sw.Stop();
            Console.WriteLine($"Time taken with exception handling: {sw.ElapsedMilliseconds} ms");

            sw.Reset();
            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                // Using input validation
                int num;
                if (int.TryParse("not an integer", out num))
                {
                    // Use the parsed integer value
                }
            }

            sw.Stop();
            Console.WriteLine($"Time taken with input validation: {sw.ElapsedMilliseconds} ms");

        }
    }
}
