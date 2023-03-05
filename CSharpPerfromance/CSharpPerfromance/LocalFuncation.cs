using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPerfromance
{
    internal class LocalFuncation
    {
        public static void RunTest()
        {
            const int N = 10000000;

            // Measure the time taken to create an array using a local function
            int[] arr1 = CreateArrayUsingLocalFunction(N);
            long mem1 = GC.GetTotalMemory(true);

            // Measure the time taken to create an array using a lambda expression
            int[] arr2 = CreateArrayUsingLambdaExpression(N);
            long mem2 = GC.GetTotalMemory(true);

            Console.WriteLine($"Time taken using local function: {mem1} bytes");
            Console.WriteLine($"Time taken using lambda expression: {mem2} bytes");
        }

        static int[] CreateArrayUsingLocalFunction(int n)
        {
            int[] arr = new int[n];

            // Define a local function to fill the array
            void FillArray(int[] a)
            {
                for (int i = 0; i < n; i++)
                {
                    a[i] = i;
                }
            }

            FillArray(arr);

            return arr;
        }

        static int[] CreateArrayUsingLambdaExpression(int n)
        {
            int[] arr = new int[n];

            // Use a lambda expression to fill the array
            Array.ForEach(arr, (i) => i = n);

            return arr;
        }
    }
}
