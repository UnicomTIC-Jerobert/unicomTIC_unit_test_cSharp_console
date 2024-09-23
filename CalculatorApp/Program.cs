using System;

namespace CalculatorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operation (+, -, *, /):");
            string operation = Console.ReadLine();

            int result = PerformOperation(num1, num2, operation);
            Console.WriteLine($"The result is: {result}");
        }

        public static int PerformOperation(int num1, int num2, string operation)
        {
            int result = 0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero");
                    }
                    result = num1 / num2;
                    break;
                default:
                    throw new ArgumentException("Invalid operation");
            }

            return result;
        }
    }
}
