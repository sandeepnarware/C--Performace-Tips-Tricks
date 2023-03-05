using System.Diagnostics;
using System.Text;

namespace CSharpPerfromance
{
    internal class StringAndStringBuilder
    {
        public static void RunTest()
        {
            const int iterations = 100000;            

            var stopwatch = new Stopwatch();

            // Concatenating strings using the + operator
            stopwatch.Start();
            string result = "";
            for (int i = 0; i < iterations; i++)
            {
                result += $"{i}";
            }
            stopwatch.Stop();
            Console.WriteLine("String concatenation with + operator took {0} ms", stopwatch.ElapsedMilliseconds);            

            // Concatenating strings using StringBuilder
            stopwatch.Restart();
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < iterations; i++)
            {
                stringBuilder.Append($"{i}");
            }
            string result2 = stringBuilder.ToString();
            stopwatch.Stop();
            Console.WriteLine("StringBuilder concatenation took {0} ms", stopwatch.ElapsedMilliseconds);
        }
    }
}

/*
 In .NET, the StringBuilder class uses an internal buffer of type char[] to store the characters that make up the string being built. 
This buffer is initialized with a default capacity of 16 characters and is resized dynamically as needed to accommodate more characters.
 */