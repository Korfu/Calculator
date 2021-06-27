using System;

namespace ConsoleCalculator
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            var nonNullOperation = operation ?? throw new ArgumentNullException(nameof(operation));
            // if (operation == null)
            //     throw new ArgumentNullException(nameof(operation));

            if (nonNullOperation == "/")
            {
                try
                {
                    return Divide(number1, number2);
                }
                catch (DivideByZeroException ex)
                {
                    // throw;
                    throw new ArithmeticException("Error occured when dividing by 0", ex);
                }
            }

            throw new ArgumentOutOfRangeException(nameof(operation), "The operator is not supported");
            // Console.WriteLine("Unkown operation");
            // return 0;
        }

        private int Divide(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}