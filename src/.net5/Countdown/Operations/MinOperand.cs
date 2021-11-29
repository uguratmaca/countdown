using Countdown.Models;

namespace Countdown.Operations
{
    internal class MinOperand : IOperand
    {
        public Calculation Calculate(int number1, int number2)
        {
            var result = new Calculation();
            if (number1 == number2)
            {
                result.Ignore = true;
                return result;
            }

            result.NewNumber = number1 - number2;

            if (result.NewNumber == number1 || result.NewNumber == number2)
            {
                result.Ignore = true;
                return result;
            }

            result.Result = $"{number1} - {number2} = {result.NewNumber}";
            return result;
        }
    }
}
