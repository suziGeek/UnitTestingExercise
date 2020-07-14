using System;
using Xunit;
using Xunit.Sdk;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(4,5,6,15)]
        [InlineData(200, 500, 60, 760)]

        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var calculator = new UnitTestMethods();

            //Act
            var actual = calculator.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10,5,5)]
        [InlineData(20, 5, 15)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var subtract = new UnitTestMethods();

            //Act
            var actual = subtract.Subtract(minuend,subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,5,10)]
        [InlineData(3, 5, 15)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var multiply = new UnitTestMethods();

            //Act
            var actual = multiply.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,2,5)]
        [InlineData(21, 3, 7)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var divide = new UnitTestMethods();

            //Act
            var actual = divide.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
