using System;
using System.Security.Cryptography;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        private Hand_Testing_Calculator.Calculator _calc = null;
        [SetUp]
        public void Setup()
        {
           _calc = new Hand_Testing_Calculator.Calculator();
        }

        [TestCase(0,0, 0)]
        [TestCase(0,1, 1)]
        [TestCase(0,-1, -1)]
        [TestCase(1,0, 1)]
        [TestCase(1,1, 2)]
        [TestCase(1,-1, 0)]
        [TestCase(-1,0, -1)]
        [TestCase(-1,1, 0)]
        [TestCase(-1,-1, -2)]

        public void AddTest(double a, double b, double res)
        {
            Assert.That(_calc.Add(a,b),Is.EqualTo(res));
        }

        [TestCase(0, 0, 0)]
        [TestCase(0, 1, -1)]
        [TestCase(0, -1, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(1, 1, 0)]
        [TestCase(1, -1, 2)]
        [TestCase(-1, 0, -1)]
        [TestCase(-1, 1, -2)]
        [TestCase(-1, -1, 0)]
        public void SubtractTest(double a, double b, double res)
        {
            Assert.That(_calc.Subtract(a,b), Is.EqualTo(res));
        }


        [TestCase(0, 0, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(0, -1, 0)]
        [TestCase(1, 0, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(1, -1, -1)]
        [TestCase(-1, 0, 0)]
        [TestCase(-1, 1, -1)]
        [TestCase(-1, -1, 1)]
        public void MultiplyTest(double a, double b, double res)
        {
            Assert.That(_calc.Multiply(a,b),Is.EqualTo(res));
        }

        [TestCase(0, 0, 1)]
        [TestCase(0, 1, 0)]
        [TestCase(0, -1, double.PositiveInfinity)]
        [TestCase(1, 0, 1)]
        [TestCase(1, 1, 1)]
        [TestCase(1, -2, 1)]
        [TestCase(-1, 0, 1)]
        [TestCase(-1, 1, -1)]
        [TestCase(-1, -2, 1)]
        public void PowerTest(double a, double exp, double res)
        {
            Assert.That(_calc.Power(a, exp), Is.EqualTo(res));
        }

        [TearDown]
        public void TearDown()
        {
            _calc = null;
        }
    }
}