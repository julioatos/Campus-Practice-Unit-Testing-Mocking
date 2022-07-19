

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
            int number = 5;
            int expected = 120;
            Mock<ICalculator> calculator = new Mock<ICalculator>();
            Series series = new Series(calculator.Object);
            calculator.Setup(c => c.Mul(number, series.Factorial(number - 1))).Returns(expected);


            int actual = series.Factorial(number);

            Assert.Equal(expected, actual);
        }
    }
}
