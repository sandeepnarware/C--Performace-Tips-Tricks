using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPerfromance
{
    internal class HashSet
    {
        public static void RunTest()
        {
            // Create a list of integers with duplicates
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Measure the time taken to remove duplicates from the list
            Stopwatch listStopwatch = Stopwatch.StartNew();
            List<int> distinctList = new List<int>(list.Distinct());
            listStopwatch.Stop();

            // Measure the time taken to remove duplicates from the hash set
            Stopwatch hashSetStopwatch = Stopwatch.StartNew();
            HashSet<int> distinctHashSet = new HashSet<int>(list);
            hashSetStopwatch.Stop();

            // Print the results
            Console.WriteLine($"List distinct count: {distinctList.Count}, time taken: {listStopwatch.Elapsed}");
            Console.WriteLine($"HashSet distinct count: {distinctHashSet.Count}, time taken: {hashSetStopwatch.Elapsed}");
        }
    }
}
