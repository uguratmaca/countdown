using Countdown.Models;

namespace Countdown.Operations
{
    internal interface IOperand
    {
        Calculation Calculate(int number1, int number2);
    }
}
