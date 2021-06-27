using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number!");
            var number1 = int.Parse(Console.ReadLine());
            
            
            Console.WriteLine("Enter second number!");
            var number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation!");
            var operation = Console.ReadLine()?.ToUpperInvariant();
            
            var calculator = new Calculator();
            var result = calculator.Calculate(number1, number2, operation);
            DisplayResult(result);
            
            Console.WriteLine("\nPress enter to exit");
            Console.ReadLine();
        }

        private static void DisplayResult(int result)
        {
            Console.WriteLine($"Result is {result}");
        }
    }
}