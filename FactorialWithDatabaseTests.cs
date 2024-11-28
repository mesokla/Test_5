using Moq;
using Xunit;

namespace FactorialApp.Tests
{
    public class FactorialWithDatabaseTests
    {
        [Fact]
        public void FactorialWithDatabase_ShouldReturnCorrectValue()
        {

            var mockDatabase = new Mock<IDatabase>();
            

            mockDatabase.Setup(db => db.GetNumber()).Returns(5);
            

            var factorial = new Factorial();
            int result = factorial.Compute(mockDatabase.Object.GetNumber());
            

            Assert.Equal(120, result);
        }
    }
}