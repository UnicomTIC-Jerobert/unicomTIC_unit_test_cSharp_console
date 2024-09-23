using System;

namespace CalculatorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool continueRunning = true;

            while (continueRunning)
            {
                Console.Clear(); // Clear the console at the start of each iteration
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("Enter the first number:");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the operation (+, -, *, /):");
                string operation = Console.ReadLine();

                try
                {
                    int result = PerformOperation(num1, num2, operation);
                    Console.WriteLine($"The result is: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine("Press 'Q' to quit or any other key to perform another operation...");
                char key = Console.ReadKey().KeyChar;
                if (char.ToUpper(key) == 'Q')
                {
                    continueRunning = false; // Exit the loop
                }
            }

            Console.Clear(); // Clear the console when exiting
            Console.WriteLine("Thank you for using the calculator. Goodbye!");
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
