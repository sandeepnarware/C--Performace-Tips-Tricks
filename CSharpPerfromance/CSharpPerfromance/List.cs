using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPerfromance
{
    internal class List
    {
        public static void RunTest()
        {
            const int iterations = 1000000;

            var stopwatch = new Stopwatch();

            // List without capacity
            stopwatch.Start();
            var list1 = new List<int>();
            for (int i = 0; i < iterations; i++)
            {
                list1.Add(i);
            }
            stopwatch.Stop();
            Console.WriteLine("List without capacity took {0} ms", stopwatch.ElapsedMilliseconds);

            // List with capacity
            stopwatch.Restart();
            var list2 = new List<int>(iterations);
            for (int i = 0; i < iterations; i++)
            {
                list2.Add(i);
            }
            stopwatch.Stop();
            Console.WriteLine("List with capacity took {0} ms", stopwatch.ElapsedMilliseconds);

        }
    }
}
