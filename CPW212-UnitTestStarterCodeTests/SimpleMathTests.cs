using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW212_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212_UnitTestStarterCode.Tests
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
            double result = num1 + num2;

            double total = SimpleMath.Add(num1, num2);

            Assert.AreEqual(result, total);
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {

            double result = num1 * num2;

            double total = SimpleMath.Multiply(num1, num2);

            Assert.AreEqual(result, total);
        }

        [TestMethod]
        [DataRow(3, -0)]
        [DataRow(2, 0)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1, double num2)
        {
            Assert.ThrowsException<ArgumentException>
                (
                    () => SimpleMath.Divide(num1, num2)
                );
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        public void Divide_TwoValidNums_ReturnsProduct(double num1, double num2)
        {
            double result = num1 / num2;

            double total = SimpleMath.Divide(num1, num2);

            Assert.AreEqual(result, total);
        }

        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Subtract_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            double result = num1 - num2;

            double total = SimpleMath.Subtract(num1, num2);

            Assert.AreEqual(result, total);
        }
    }
}