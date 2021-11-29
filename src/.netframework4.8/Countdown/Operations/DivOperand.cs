using Countdown.Models;

namespace Countdown.Operations
{
    internal class DivOperand : IOperand
    {
        public Calculation Calculate(int number1, int number2)
        {
            var result = new Calculation();
            if (number1 == 1 || number2 == 1)
            {
                result.Ignore = true;
                return result;
            }

            int remainder = number1 % number2;
            if (remainder != 0)
            {
                result.Ignore = true;
                return result;
            }

            result.NewNumber = number1 / number2;
            result.Result = $"{number1} / {number2} = {result.NewNumber}";
            return result;
        }
    }
}
