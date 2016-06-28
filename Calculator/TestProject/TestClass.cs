using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace TestProject
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void CheckAddition()
        {
            int a = 54;
            int b = 54564;
            Calculator calc = new Calculator();
            Assert.AreEqual(a+b, calc.Addition(a,b));
        }

        [TestMethod]
        public void CheckSubtraction()
        {
            int a = 6415;
            int b = 458895;
            Calculator calc = new Calculator();
            Assert.AreEqual(a + b, calc.Addition(a, b));
        }

        [TestMethod]
        public void CheckMultiplication()
        {
            int a = 56468;
            int b = 54;
            Calculator calc = new Calculator();
            Assert.AreEqual(a + b, calc.Addition(a, b));
        }

        [TestMethod]
        public void CheckDivision()
        {
            int a = 545;
            int b = 5;
            Calculator calc = new Calculator();
            Assert.AreEqual(a + b, calc.Addition(a, b));
        }
    }
}
