using Countdown.Models;

namespace Countdown.Operations
{
    internal class SumOperand : IOperand
    {
        public Calculation Calculate(int number1, int number2)
        {
            var result = new Calculation
            {
                NewNumber = number1 + number2
            };

            if (result.NewNumber == 0)
            {
                result.Ignore = true;
                return result;
            }

            result.Result = $"{number1} + {number2} = {result.NewNumber}";
            return result;
        }
    }
}
