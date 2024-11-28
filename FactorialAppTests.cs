using Xunit;
using FactorialApp;

namespace FactorialApp.Tests
{
    public class FactorialAppTests
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(5, 120)]
        [InlineData(10, 3628800)]
        public void FactorialShouldReturnExpectedResult(int input, int expected)
        {
            var factorial = new Factorial();
            Assert.Equal(expected, factorial.Compute(input));
        }



        [Fact]
        public void FactorialOfNegativeShouldThrowException()
        {
            var factorial = new Factorial();
            Assert.Throws<ArgumentException>(() => factorial.Compute(-1));
        }
    }
}