using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathToolsMenu;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddingNumber()
        {
            //Arrange
            string number1 = "123";
            string expected = "123";
            CalculatorControl addingNumber = new CalculatorControl();

            //Act
            addingNumber.addNumber(number1);

            //Assert
            Assert.AreEqual(addingNumber.FirstNumber, expected);
        }

        [TestMethod]
        public void AddingNumber2()
        {
            //Arrange
            string number2 = "123";
            CalculatorControl addingNumber = new CalculatorControl();

            //Act
            addingNumber.addNumber(number2);

            //Assert
            Assert.IsNull(addingNumber.SecondNumber);
        }

        [TestMethod]
        public void AddingSymbol()
        {
            //Arrange
            string number = "123";
            char symbol = '+';
            char expected = '+';
            CalculatorControl addingSymbol = new CalculatorControl();

            //Act
            addingSymbol.addNumber(number);
            addingSymbol.addActionSymbol(symbol);

            //Assert
            Assert.AreEqual(addingSymbol.ActionSymbol, expected);
        }

        [TestMethod]
        public void AddingNumber3()
        {
            //Arrange
            string number2 = "123";
            string expected = "123";
            CalculatorControl addingNumber = new CalculatorControl();

            //Act
            addingNumber.addNumber(number2);
            addingNumber.addActionSymbol('+');
            addingNumber.addNumber(number2);

            //Assert
            Assert.AreEqual(addingNumber.SecondNumber, expected);
        }
    }
}
