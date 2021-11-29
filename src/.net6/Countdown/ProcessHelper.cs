using Countdown.Models;
using Countdown.Operations;

namespace Countdown
{
    internal class ProcessHelper
    {
        internal static Depth AddDepth(Depth stackItem, Calculation result, int i, int j)
        {
            var newNumbers = new List<int>
            {
                result.NewNumber
            };

            for (int k = 0; k < stackItem.Numbers.Count(); k++)
            {
                if (k != i && k != j) //ignore used numbers
                {
                    newNumbers.Add(stackItem.Numbers[k]);
                }
            }

            return new Depth
            {
                Result = stackItem.Result + Environment.NewLine + result.Result,
                Numbers = newNumbers
            };
        }

        internal static void Finalize(int target, Calculation r, Depth d = null)
        {
            Console.WriteLine($"{Environment.NewLine}Target was {target}. Calculations to reach target {d.Result}{Environment.NewLine}{r.Result}");
        }
        internal static void Calculate(List<IOperand> operands, Problem countdown)
        {
            var queue = new Queue<Depth>();
            queue.Enqueue(new Depth { Numbers = countdown.GivenNumbers });

            while (queue.Count() > 0)
            {
                var stackItem = queue.Dequeue();

                for (int i = 0; i < stackItem.Numbers.Count() - 1; i++)
                {
                    for (int j = i + 1; j < stackItem.Numbers.Count(); j++)
                    {
                        foreach (var operand in operands)
                        {
                            var result = operand.Calculate(stackItem.Numbers[i], stackItem.Numbers[j]);
                            if (result.NewNumber == countdown.Target)
                            {
                                ProcessHelper.Finalize(countdown.Target, result, stackItem);
                                goto newTarget;
                            }
                            if (!result.Ignore)
                            {
                                queue.Enqueue(ProcessHelper.AddDepth(stackItem, result, i, j));
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Interesting, no result found!{Environment.NewLine}");

        newTarget:
            Console.WriteLine($"Starting new countdown!{Environment.NewLine}");
        }
    }
}
