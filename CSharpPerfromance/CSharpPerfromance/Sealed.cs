using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPerfromance
{
    internal class Sealed
    {
        public static void RunTest()
        {
            var iterations = 10000000;
            var stopwatch = new Stopwatch();

            // Test with unsealed class
            var unsealed = new UnsealedClass();
            stopwatch.Start();
            for (int i = 0; i < iterations; i++)
            {
                unsealed.DoSomething();
            }
            stopwatch.Stop();
            Console.WriteLine("Unsealed class: {0} ms", stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();

            // Test with sealed class
            var sealedClass = new SealedClass();
            stopwatch.Start();
            for (int i = 0; i < iterations; i++)
            {
                sealedClass.DoSomething();
            }
            stopwatch.Stop();
            Console.WriteLine("Sealed class: {0} ms", stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
        }
    }
}
