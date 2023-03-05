using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPerfromance
{
    internal class LinkedListRemoveAddLast
    {
        public static void RunTest()
        {
            const int iterations = 100000;

            // Test with List<int>
            var list = new List<int>();
            var listWatch = Stopwatch.StartNew();
            for (int i = 0; i < iterations; i++)
            {
                list.Add(i);
            }
            listWatch.Stop();
            Console.WriteLine($"List<int> Elapsed Time (write): {listWatch.Elapsed}");

            listWatch.Restart();
            foreach (var item in list)
            {
                // do magic here
            }

            listWatch.Stop();
            Console.WriteLine($"List<int> Elapsed Time (read): {listWatch.Elapsed}");


            listWatch.Restart();
            for (int i = 1; i <= 10; i++)
            {  
                list.Insert(list.IndexOf(i * 100), 100);
            }

            listWatch.Stop();
            Console.WriteLine($"List<int> Elapsed Time (insert): {listWatch.Elapsed}");


            // Test with LinkedList<int>
            var linkedList = new LinkedList<int>();
            var linkedListWatch = Stopwatch.StartNew();
            for (int i = 0; i < iterations; i++)
            {
                linkedList.AddLast(i);
            }
            linkedListWatch.Stop();
            Console.WriteLine($"LinkedList<int> Elapsed Time (write): {linkedListWatch.Elapsed}");

            linkedListWatch.Restart();
            foreach (var item in linkedList)
            {
                // do magic here
            }
            linkedListWatch.Stop();
            Console.WriteLine($"LinkedList<int> Elapsed Time (read): {linkedListWatch.Elapsed}");


            linkedListWatch.Restart();
            for (int i = 1; i <= 10; i++)
            {
                var element = linkedList.Find(i * 100);
                linkedList.AddAfter(element, 100);
            }
            linkedListWatch.Stop();
            Console.WriteLine($"LinkedList<int> Elapsed Time (insert): {linkedListWatch.Elapsed}");
        }
    }
}
