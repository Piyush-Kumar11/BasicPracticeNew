using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    internal class FindExecutionTime
    {
        public static void ExecutionTime()
        {
            var watch = Stopwatch.StartNew();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello World!!!");
            }

            watch.Stop();

            Console.WriteLine(
                $"The Execution time of the program is {watch.ElapsedMilliseconds}ms");
        }
    }
}
