using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPerfromance
{
    internal class FloatVsDecimal
    {
        public static void TestRun()
        {
            const int n = 10000000;
            float[] floatArray = new float[n];
            decimal[] decimalArray = new decimal[n];

            // Initialize the arrays with random values
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                floatArray[i] = (float)r.NextDouble();
                decimalArray[i] = (decimal)r.NextDouble();
            }

            // Test performance of float calculations
            Stopwatch sw1 = Stopwatch.StartNew();
            float sumFloat = 0;
            for (int i = 0; i < n; i++)
            {
                sumFloat += floatArray[i];
            }
            sw1.Stop();
            Console.WriteLine($"Time taken for float calculations: {sw1.ElapsedMilliseconds} ms");

            // Test performance of decimal calculations
            Stopwatch sw2 = Stopwatch.StartNew();
            decimal sumDecimal = 0;
            for (int i = 0; i < n; i++)
            {
                sumDecimal += decimalArray[i];
            }
            sw2.Stop();
            Console.WriteLine($"Time taken for decimal calculations: {sw2.ElapsedMilliseconds} ms");
        }
    }
}
