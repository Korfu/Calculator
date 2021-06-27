using System;

namespace ConsoleCalculator
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            if (operation == "/")
                return Divide(number1, number2);

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