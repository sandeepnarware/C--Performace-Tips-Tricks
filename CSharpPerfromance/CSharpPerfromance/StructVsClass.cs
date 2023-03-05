using System.Diagnostics;
using System.Threading.Tasks.Sources;

namespace CSharpPerfromance
{
    internal class StructVsClass
    {
        public static void RunTest()
        {
            const int N = 10000000;

            var stopwatch = Stopwatch.StartNew();

            // Create an array of Point objects
            Student[] pointArray = new Student[N];
            for (int i = 0; i < N; i++)
            {
                pointArray[i] = new Student{ Name = "X" };
            }
            for (int i = 0; i < N; i++)
            {
                var x = pointArray.ElementAt(i).Name;
            }
            stopwatch.Stop();
            Console.WriteLine($"Time taken for Point object operations: {stopwatch.Elapsed.TotalMilliseconds} ms");

            stopwatch.Restart();
            StudentStruct[] pointStructArray = new StudentStruct[N];
            for (int i = 0; i < N; i++)
            {
                pointStructArray[i] = new StudentStruct{ Name = "X" };
            }         
            for (int i = 0; i < N; i++)
            {
                var x = pointStructArray.ElementAt(i).Name;
            }
            stopwatch.Stop();
            Console.WriteLine($"Time taken for PointStruct object operations: {stopwatch.Elapsed.TotalMilliseconds} ms");           
        }
    }

   
    class Student
    {
        public string Name { get; set; }
    }
   
    class StudentStruct
    {
        public string Name { get; set; }
    }
}
