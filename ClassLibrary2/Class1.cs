using Calculators;
using System;
using Xunit;

namespace UnitTesting
{
    public class Class1
    {
        [Fact]
        public void AddShouldCalculate()
        {
            // Arrange
            var calculator = new Calculator();
            float number1 = 2.6f;
            float number2 = 2.6f;
            float expected = 5.2f;

            // Act
            double actual = calculator.Add(number1, number2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubShouldCalculate()
        {
            // Arrange
            var calculator = new Calculator();
            float number1 = 10.0f;
            float number2 = 5.5f;
            float expected = 4.5f;

            // Act
            float actual = calculator.Sub(number1, number2);

            // Asser
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(2.5f, 10.5f, 26.25f)]
        [InlineData(33.79f, 62.8f, 2122.012f)]
        [InlineData(10.5f, 4.5f, 47.25f)]
        [InlineData(9.2f, 7.2f, 66.24f)]
        [InlineData(4.4f, 13f, 57.2f)]
        public void MulShouldCalculate(float number1, float number2, float expected)
        {
            // Arrange
            var calculadora = new Calculator();
            // Act
            float actual = calculadora.Mul(number1, number2);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(10f, 1f, 10f)]
        [InlineData(10f, 2f, 5f)]
        [InlineData(10f, 10f, 1f)]
        [InlineData(15f, 3f, 5f)]
        [InlineData(40f, 5f, 8f)]
        public void DivShouldCalculate(float number1, float number2, float expected)
        {
            // Arrange
            var calculadora = new Calculator();

            // Act
            float actual = calculadora.Div(number1, number2);

            // Assert

            Assert.Equal(expected, actual);
        }
    }
}
