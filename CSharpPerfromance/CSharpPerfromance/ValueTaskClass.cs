using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPerfromance
{
    public class ValueTaskClass
    {
        public static async void RunTask()
        {
            Console.WriteLine("Starting program...");
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < 100000; i++)
            {
                await ComputeAsyncWithTask(i);
            }

            stopwatch.Stop();
            Console.WriteLine($"Using Task: Elapsed time: {stopwatch.ElapsedMilliseconds}ms");

            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < 100000; i++)
            {
                await ComputeAsyncWithValueTask(i);
            }

            stopwatch.Stop();
            Console.WriteLine($"Using ValueTask: Elapsed time: {stopwatch.ElapsedMilliseconds}ms");

            Console.ReadLine();
        }

        static async Task ComputeAsyncWithTask(int i)
        {
            await Task.Delay(10);
        }

        static async ValueTask ComputeAsyncWithValueTask(int i)
        {
            await Task.Delay(10);           
        }
    }
}
