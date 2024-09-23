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

            int result = Add(num1, num2);
            Console.WriteLine($"The result is: {result}");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
