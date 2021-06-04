using NUnit.Framework;
using ConsoleCalculator;

namespace ConsoleCalculatorTest
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Basic_Addition_of_Two_Numbers()
        {
            // Arrange
            Calculator calculator = new Calculator();
            calculator.FirstNumber = 10.2;
            calculator.SecondNumber = 5.5;

            // Act
            double actualResult = calculator.Addition();
            double expectedResult = 15.7;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
