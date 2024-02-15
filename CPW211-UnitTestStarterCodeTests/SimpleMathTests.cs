using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            double expectedReturn = num1 + num2;
            double actualReturn = SimpleMath.Add(num1, num2);

            Assert.AreEqual(expectedReturn, actualReturn);
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Subtract_TwoNumbers_ReturnsDifference(double num1, double num2)
        {
            double expectedReturn = num1 - num2;
            double actualReturn = SimpleMath.Subtract(num1, num2);

            Assert.AreEqual(expectedReturn, actualReturn);
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {

            double expectedReturn = num1 * num2;
            double actualReturn = SimpleMath.Multiply(num1, num2);

            Assert.AreEqual(expectedReturn, actualReturn);
        }

        [TestMethod]
        [DataRow(5, 0)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1, double num2)
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            Assert.ThrowsException<DivideByZeroException>(() => SimpleMath.Divide(num1, num2));
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod()]
        [DataRow(20, 4)]
        [DataRow(1, 3)]
        [DataRow(8, -8)]
        public void Divide_TwoNumbers_ReturnsQuotient(double num1, double num2)
        {
            double expectedReturn = num1 / num2;
            double actualReturn = SimpleMath.Divide(num1, num2);

            Assert.AreEqual(expectedReturn, actualReturn);
        }
    }
}