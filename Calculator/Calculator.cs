using System;
using System.Collections.Generic;
using System.Text;

namespace Hand_Testing_Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double a, double exp)
        {
            return Math.Pow(a, exp);
        }

        public double Divide(double divident, double divisor)
        {
            if (divisor == 0)
                throw new ArgumentException("Divide by zero");
            return divident / divisor;
        }
    }

}
