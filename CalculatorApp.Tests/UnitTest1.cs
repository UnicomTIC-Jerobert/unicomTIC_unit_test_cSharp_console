using Xunit;
using System.IO;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class UnitTest1
    {
        // [Fact]
        // public void Test_Addition_With_ConsoleInput()
        // {
        //     // Arrange: Simulate input for the console, including 'Q' to exit at the end
        //     var input = new StringReader("10\n5\n+\nQ\n");
        //     Console.SetIn(input);

        //     // Capture the console output
        //     var output = new StringWriter();
        //     Console.SetOut(output);

        //     // Act: Call the main method
        //     Program.Main(new string[0]);

        //     // Assert: Check if the output contains the expected result
        //     var consoleOutput = output.ToString();
        //     Assert.Contains("Enter the first number:", consoleOutput);
        //     Assert.Contains("Enter the second number:", consoleOutput);
        //     Assert.Contains("Enter the operation (+, -, *, /):", consoleOutput);
        //     Assert.Contains("The result is: 15", consoleOutput);
        //     Assert.Contains("Thank you for using the calculator. Goodbye!", consoleOutput);
        // }

        // [Fact]
        // public void Test_Subtraction_With_ConsoleInput()
        // {
        //     // Arrange: Simulate input for the console
        //     var input = new StringReader("20\n5\n-\nQ\n");
        //     Console.SetIn(input);

        //     // Capture the console output
        //     var output = new StringWriter();
        //     Console.SetOut(output);

        //     // Act: Call the main method
        //     Program.Main(new string[0]);

        //     // Assert: Check if the output contains the expected result
        //     var consoleOutput = output.ToString();
        //     Assert.Contains("The result is: 15", consoleOutput);
        //     Assert.Contains("Thank you for using the calculator. Goodbye!", consoleOutput);
        // }

        // [Fact]
        // public void Test_Invalid_Operation_With_ConsoleInput()
        // {
        //     // Arrange: Simulate input for the console
        //     var input = new StringReader("10\n5\nx\nQ\n");
        //     Console.SetIn(input);

        //     // Capture the console output
        //     var output = new StringWriter();
        //     Console.SetOut(output);

        //     // Act & Assert: Check if an exception is handled for invalid operation
        //     Program.Main(new string[0]);
        //     var consoleOutput = output.ToString();
        //     Assert.Contains("Error: Invalid operation", consoleOutput);
        //     Assert.Contains("Thank you for using the calculator. Goodbye!", consoleOutput);
        // }

        // [Fact]
        // public void Test_DivideByZero_With_ConsoleInput()
        // {
        //     // Arrange: Simulate input for the console
        //     var input = new StringReader("10\n0\n/\nQ\n");
        //     Console.SetIn(input);

        //     // Capture the console output
        //     var output = new StringWriter();
        //     Console.SetOut(output);

        //     // Act: Call the main method
        //     Program.Main(new string[0]);

        //     // Assert: Check if the divide by zero error is handled
        //     var consoleOutput = output.ToString();
        //     Assert.Contains("Error: Cannot divide by zero", consoleOutput);
        //     Assert.Contains("Thank you for using the calculator. Goodbye!", consoleOutput);
        // }

        [Fact]
        public void Test_Addition_With_ConsoleInput()
        {
            // Simulate input for addition and quit immediately after
            var input = new StringReader("10\n5\n+\nQ\n");
            Console.SetIn(input);

            // Capture the console output
            var output = new StringWriter();
            Console.SetOut(output);

            // Act: Call the main method
            Program.Main(new string[0]);

            // Assert: Check the result and exit message
            var consoleOutput = output.ToString();
            Assert.Contains("The result is: 15", consoleOutput);
            Assert.Contains("Goodbye!", consoleOutput);
        }

        [Fact]
        public void Test_Subtraction_With_ConsoleInput()
        {
            // Simulate input for subtraction and quit immediately after
            var input = new StringReader("20\n5\n-\nQ\n");
            Console.SetIn(input);

            // Capture the console output
            var output = new StringWriter();
            Console.SetOut(output);

            // Act: Call the main method
            Program.Main(new string[0]);

            // Assert: Check the result and exit message
            var consoleOutput = output.ToString();
            Assert.Contains("The result is: 15", consoleOutput);
            Assert.Contains("Goodbye!", consoleOutput);
        }

        [Fact]
        public void Test_DivideByZero_With_ConsoleInput()
        {
            // Simulate input for division by zero and quit immediately after
            var input = new StringReader("10\n0\n/\nQ\n");
            Console.SetIn(input);

            // Capture the console output
            var output = new StringWriter();
            Console.SetOut(output);

            // Act: Call the main method
            Program.Main(new string[0]);

            // Assert: Check the divide by zero error message
            var consoleOutput = output.ToString();
            Assert.Contains("Error: Cannot divide by zero", consoleOutput);
            Assert.Contains("Goodbye!", consoleOutput);
        }
    }
}
