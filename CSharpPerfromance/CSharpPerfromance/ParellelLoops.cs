using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPerfromance
{
    internal class ParellelLoops
    {
        public static void TestRun()
        {
            const int N = 10000000;
            List<int> list = new List<int>(N);

            // Populate the list with random integers
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                list.Add(rnd.Next(1000));
            }

            // Measure the time taken to sum the elements using foreach
            long sum = 0;
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            foreach (int num in list)
            {
                sum += num;
            }
            sw1.Stop();
            Console.WriteLine($"Time taken using foreach: {sw1.ElapsedMilliseconds} ms");
            Console.WriteLine($"Sum using foreach: {sum}");

            // Measure the time taken to sum the elements using Parallel.ForEach
            sum = 0;
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            Parallel.ForEach(list, (num) =>
            {
                Interlocked.Add(ref sum, num);
            });
            sw2.Stop();
            Console.WriteLine($"Time taken using Parallel.ForEach: {sw2.ElapsedMilliseconds} ms");
            Console.WriteLine($"Sum using Parallel.ForEach: {sum}");
        }
    }
}
