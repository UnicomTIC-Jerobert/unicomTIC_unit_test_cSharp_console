using Xunit;
using System.IO;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Addition_With_ConsoleInput()
        {
            // Arrange: Simulate input for the console
            var input = new StringReader("10\n5\n+\n");
            Console.SetIn(input);

            // Capture the console output
            var output = new StringWriter();
            Console.SetOut(output);

            // Act: Call the main method
            Program.Main(new string[0]);

            // Assert: Check if the output contains the expected result
            var consoleOutput = output.ToString();
            Assert.Contains("Enter the first number:", consoleOutput);
            Assert.Contains("Enter the second number:", consoleOutput);
            Assert.Contains("Enter the operation (+, -, *, /):", consoleOutput);
            Assert.Contains("The result is: 14", consoleOutput);
        }

        [Fact]
        public void Test_Subtraction_With_ConsoleInput()
        {
            // Arrange: Simulate input for the console
            var input = new StringReader("20\n5\n-\n");
            Console.SetIn(input);

            // Capture the console output
            var output = new StringWriter();
            Console.SetOut(output);

            // Act: Call the main method
            Program.Main(new string[0]);

            // Assert: Check if the output contains the expected result
            var consoleOutput = output.ToString();
            Assert.Contains("The result is: 15", consoleOutput);
        }

        [Fact]
        public void Test_Invalid_Operation_With_ConsoleInput()
        {
            // Arrange: Simulate input for the console
            var input = new StringReader("10\n5\nx\n");
            Console.SetIn(input);

            // Capture the console output
            var output = new StringWriter();
            Console.SetOut(output);

            // Act & Assert: Since the operation is invalid, expect an exception
            Assert.Throws<ArgumentException>(() => Program.Main(new string[0]));
        }
    }
}
