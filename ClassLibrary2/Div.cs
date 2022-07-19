using Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTesting
{
    public class Div
    {
        [Fact]
        public void ShouldRaiseErrorWhenDividingByZero()
        {
            // Arrange
            var calculadora = new Calculators.Calculator();

            // Act

            // Assert
            Assert.Throws<DivideByZeroException>(() => calculadora.Div(0, 0));
        }
    }
}
