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

        [TestCase(5, 0, 5)]
        [TestCase(6, 1, 7)]
        [TestCase(7, -1, 6)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 1, 1)]
        [TestCase(0, -1, -1)]
        [TestCase(-5, 0, -5)]
        [TestCase(-6, 1, -4)]
        [TestCase(-7, -1, -8)]
        public void AddOverloadOneParamTest(double initial, double b, double res)
        {
            //Store the initial value in accumulator
            _calc.Add(initial, 0);
            //Test overload
            Assert.That(_calc.Add(b), Is.EqualTo(res));
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

        [TestCase(5, 0, 5)]
        [TestCase(6, 1, 5)]
        [TestCase(7, -1, 8)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 1, -1)]
        [TestCase(0, -1, 1)]
        [TestCase(-5, 0, -5)]
        [TestCase(-6, 1, -7)]
        [TestCase(-7, -1, -6)]
        public void SubtractOverloadOneParamTest(double initial, double b, double res)
        {
            //Store the initial value in accumulator
            _calc.Add(initial, 0);
            //Test overload
            Assert.That(_calc.Subtract(b), Is.EqualTo(res));
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

        [TestCase(5, 0, 0)]
        [TestCase(6, 1, 6)]
        [TestCase(7, -1, -7)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(0, -1, 0)]
        [TestCase(-5, 0, 0)]
        [TestCase(-6, 1, -6)]
        [TestCase(-7, -1, 7)]
        public void MultiOverloadOneParamTest(double initial, double b, double res)
        {
            //Store the initial value in accumulator
            _calc.Add(initial, 0);
            //Test overload
            Assert.That(_calc.Multiply(b), Is.EqualTo(res));
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

        [TestCase(5, 0, 1)]
        [TestCase(6, 2, 36)]
        [TestCase(7, -2, 3.5)]
        [TestCase(0, 0, 1)]
        [TestCase(0, 1, 0)]
        [TestCase(0, -1, double.PositiveInfinity)]
        [TestCase(-5, 0, 1)]
        [TestCase(-6, 1, -6)]
        [TestCase(-2, -1, -0.5)]
        public void PowerOverloadOneParamTest(double initial, double b, double res)
        {
            //Store the initial value in accumulator
            _calc.Add(initial, 0);
            //Test overload
            Assert.That(_calc.Power(b), Is.EqualTo(res));
        }

        [TestCase(0, 1, 0)]
        [TestCase(0, -1, 0)]
        [TestCase(1, 2, 0.5)]
        [TestCase(1, -1, -1)]
        [TestCase(-1, 2, -0.5)]
        [TestCase(-1, -2, 0.5)]
        public void DivideByNonZeroTest(double a, double b, double res)
        {
            Assert.That(_calc.Divide(a, b), Is.EqualTo(res));
        }
        
        [TestCase(6, 2, 3)]
        [TestCase(9, -3, -3)]
        [TestCase(0, 2, 0)]
        [TestCase(0, -1, 0)]
        [TestCase(-1, 2, -0.5)]
        [TestCase(-5, -2, 2.5)]

        public void DivideOverloadOneParamNonZeroTest(double initial, double b, double res)
        {
            //Store the initial value in accumulator
            _calc.Add(initial, 0);
            //Test overload
            Assert.That(_calc.Divide(b), Is.EqualTo(res));
        }


        [TestCase(-1)]
        [TestCase(1)]
        [TestCase(0)]

        public void DivideByZeroThrowsArgumentExeptionTest(double a)
        {
            Assert.Throws<ArgumentException>(() => _calc.Divide(a, 0));
        }

        [TestCase(0)]
        [TestCase(3)]
        [TestCase(-2)]
        public void DivideOverloadOneParamNonZeroTest(double initial)
        {
            //Store the initial value in accumulator
            _calc.Add(initial, 0);
            //Test overload
            Assert.Throws<ArgumentException>(() => _calc.Divide( 0));
        }

        [Test]
        public void AccumulatorAtStartupIsZero()
        {
            Assert.That(_calc.Accumulator, Is.Zero);
        }

        [TestCase(0, 0, 0)]
        [TestCase(0, 1, 1)]
        [TestCase(0, -1, -1)]
        [TestCase(1, 0, 1)]
        [TestCase(1, 1, 2)]
        [TestCase(1, -1, 0)]
        [TestCase(-1, 0, -1)]
        [TestCase(-1, 1, 0)]
        [TestCase(-1, -1, -2)]
        public void AccumulatorAfterAddIsResultOfAdd(double a, double b,double res)
        {
            //Action
            _calc.Add(a, b);
            //Assert
            Assert.That(_calc.Accumulator, Is.EqualTo(res));
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
        public void AccumulatorAfterSubstactIsResultOfSubstact(double a, double b, double res)
        {
            //Action
            _calc.Subtract(a, b);
            //Assert
            Assert.That(_calc.Accumulator, Is.EqualTo(res));
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
        public void AccumulatorAfterMultiplyIsResultOfMultiply(double a, double b, double res)
        {
            //Action
            _calc.Multiply(a, b);
            //Assert
            Assert.That(_calc.Accumulator, Is.EqualTo(res));
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
        public void AccumulatorAfterPowerIsResultOfPower(double a, double b, double res)
        {
            //Action
            _calc.Power(a, b);
            //Assert
            Assert.That(_calc.Accumulator, Is.EqualTo(res));
        }

        [TestCase(0, 1, 0)]
        [TestCase(0, -1, 0)]
        [TestCase(1, 2, 0.5)]
        [TestCase(1, -1, -1)]
        [TestCase(-1, 2, -0.5)]
        [TestCase(-1, -2, 0.5)]
        public void AccumulatorAfterDivideIsResultOfDivide(double a, double b, double res)
        {
            //Action
            _calc.Divide(a, b);
            //Assert
            Assert.That(_calc.Accumulator, Is.EqualTo(res));
        }

        [TestCase(1)]
        public void AccumulatorIsNullAfterDivideByZero(double a)
        {
            //Arrange
            try
            {
                _calc.Divide(a, 0);
            }
            catch(ArgumentException)
            {

            }

            Assert.That(_calc.Accumulator, Is.Zero);
        }

        [Test]
        public void ClearClearsAccumulatorIsZero()
        {
            //Arrange
            _calc.Add(1, 1);

            //Action
            _calc.Clear();

            //Assert
            Assert.That(_calc.Accumulator, Is.Zero);
        }

        [TearDown]
        public void TearDown()
        {
            _calc = null;
        }
    }
}