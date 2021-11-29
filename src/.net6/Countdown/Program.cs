using Countdown;
using Countdown.Models;
using Countdown.Operations;
using System.Diagnostics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();

            Console.WriteLine("Started!");

            var operands = new List<IOperand>
            {
                new MulOperand(),
                new SumOperand(),
                new MinOperand(),
                new DivOperand()
            };

            var countdowns = new List<Problem>() { new Problem { GivenNumbers = new List<int> { 75, 1, 3, 4, 6, 9 }, Target = 471 } ,
                new Problem { GivenNumbers = new List<int> { 25, 1, 3, 4, 6, 9 }, Target = 311 } ,
                new Problem { GivenNumbers = new List<int> { 100, 1, 2, 3, 3, 5 }, Target = 717 } ,
                new Problem { GivenNumbers = new List<int> { 75, 2, 3, 5, 6, 9 }, Target = 388 } ,
                new Problem { GivenNumbers = new List<int> { 60, 2, 3, 4, 6, 7, 12 }, Target = 1555 } ,
                new Problem { GivenNumbers = new List<int> { 100, 2, 3, 5, 6, 8, 11, 4 }, Target = 7552 }
            };

            var iterations = 10;

            for (int i = 0; i < iterations; i++)
            {
                foreach (var countdown in countdowns)
                {
                    ProcessHelper.Calculate(operands, countdown);
                }
            }

            watch.Stop();

            Console.WriteLine($"Elapsed time {watch.ElapsedMilliseconds / iterations} ms.");
            Console.WriteLine("Finished!");
            Console.ReadKey();
        }
    }
}