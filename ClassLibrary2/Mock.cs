

using Calculators;
using Moq;
using Xunit;

namespace UnitTesting
{
    public class Mock
    {
        [Fact]
        public void FactorialShouldWorkd()
        {
            // Arrange
            int number = 5;
            int expected = 130;
            Mock<ICalculator> calculator = new Mock<ICalculator>();

            calculator.Setup(c => c.Mul(It.IsAny<int>(), It.IsAny<int>())).Returns(expected);
            Series series = new Series(calculator.Object);

            // Act
            int actual = series.Factorial(number);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FibonacciShouldWork()
        {
            // Arrange
            int number = 10;
            int expected = 55;
            Mock<ICalculator> calculator = new Mock<ICalculator>();
            calculator.Setup(c => c.Add(It.IsAny<int>(), It.IsAny<int>())).Returns(expected);
            Series series = new Series(calculator.Object);

            // Act
            int actual = series.Fibonacci(number);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
