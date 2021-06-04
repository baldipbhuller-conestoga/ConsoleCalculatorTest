using NUnit.Framework;
using ConsoleCalculator;

namespace ConsoleCalculatorTest
{
    [TestFixture]
    public class CalculatorTests
    {
        // Baldip Singh Bhuller

        [Test]
        public void Basic_Addition_of_Two_Numbers()
        {
            // Arrange
            Calculator calculator = new Calculator();
            calculator.FirstNumber = 10.2;
            calculator.SecondNumber = 5.5;

            double expectedResult = 15.7;

            // Act
            double actualResult = calculator.Addition();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void Addition_WithNegativeNumber()
        {
            // Arrange
            Calculator calculator = new Calculator();
            calculator.FirstNumber = 10;
            calculator.SecondNumber = -3;

            double expectedResult = 7;

            // Act
            double actualResult = calculator.Addition();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void Addition_DecimalRounding_3Places()
        {
            // Arrange
            Calculator calculator = new Calculator();
            calculator.FirstNumber = 12.5774;
            calculator.SecondNumber = 4.2314;

            double expectedResult = 16.809;

            // Act
            double actualResult = calculator.Addition();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void Basic_Subtraction_of_Two_Numbers()
        {
            // Arrange
            Calculator calculator = new Calculator();
            calculator.FirstNumber = 14.5;
            calculator.SecondNumber = 3.5;

            double expectedResult = 11;

            // Act
            double actualResult = calculator.Subtraction();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void Subtraction_WithNegativeResult()
        {
            // Arrange
            Calculator calculator = new Calculator();
            calculator.FirstNumber = 5;
            calculator.SecondNumber = 9;

            double expectedResult = -4;

            // Act
            double actualResult = calculator.Subtraction();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void Subtraction_DecimalRounding_3Places()
        {
            // Arrange
            Calculator calculator = new Calculator();
            calculator.FirstNumber = 100.5559;
            calculator.SecondNumber = 10.0012;

            double expectedResult = 90.555;

            // Act
            double actualResult = calculator.Subtraction();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void Basic_Multiplication_of_Two_Numbers()
        {
            // Arrange
            Calculator calculator = new Calculator();
            calculator.FirstNumber = 2;
            calculator.SecondNumber = 11.3;

            double expectedResult = 22.6;

            // Act
            double actualResult = calculator.Multiplication();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void Multiplication_WithZero()
        {
            // Arrange
            Calculator calculator = new Calculator();
            calculator.FirstNumber = 25.1;
            calculator.SecondNumber = 0;

            double expectedResult = 0;

            // Act
            double actualResult = calculator.Multiplication();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void Multiplication_WithNegativeNumber()
        {
            // Arrange
            Calculator calculator = new Calculator();
            calculator.FirstNumber = 24;
            calculator.SecondNumber = -2.5;

            double expectedResult = -60;

            // Act
            double actualResult = calculator.Multiplication();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void Basic_Division_of_Two_Numbers()
        {
            // Arrange
            Calculator calculator = new Calculator();
            calculator.FirstNumber = 24.4;
            calculator.SecondNumber = 2;

            double expectedResult = 12.2;

            // Act
            double actualResult = calculator.Division();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void Division_WithZeroDivisor()
        {
            // Arrange
            Calculator calculator = new Calculator();
            calculator.FirstNumber = 55;
            calculator.SecondNumber = 0;

            double expectedResult = double.PositiveInfinity;

            // Act
            double actualResult = calculator.Division();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void Division_WithZeroDividend()
        {
            // Arrange
            Calculator calculator = new Calculator();
            calculator.FirstNumber = 0;
            calculator.SecondNumber = 10;

            double expectedResult = 0;

            // Act
            double actualResult = calculator.Division();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
