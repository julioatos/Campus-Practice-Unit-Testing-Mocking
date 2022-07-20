

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
            int expected = 120;
            Mock<ICalculator> calculator = new Mock<ICalculator>();

            calculator.Setup(c => c.Mul(It.IsAny<int>(), It.IsAny<int>())).Returns((int number1, int number2) => number1 * number2);
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
            calculator.Setup(c => c.Add(It.IsAny<int>(), It.IsAny<int>())).Returns((int number1, int number2) => number1+number2);
            Series series = new Series(calculator.Object);

            // Act
            int actual = series.Fibonacci(number);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
