using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdd1()
        {
            int result = Program.Add(2, 3);
            Assert.Equal(5, result);
        }

         [Fact]
        public void TestAdd2()
        {
            int result = Program.Add(0, 2);
            Assert.Equal(2, result);
        }

        [Fact]
        public void TestAddWithNegativeNumbers()
        {
            int result = Program.Add(-1, -1);
            Assert.Equal(-2, result);
        }
    }
}
