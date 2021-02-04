using System;
using System.Collections.Generic;
using System.Text;

namespace Hand_Testing_Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Power(double a, double exp)
        {
            Accumulator = Math.Pow(a, exp);
            return Accumulator;
        }

        public double Divide(double divident, double divisor)
        {
            if (divisor == 0)
            {
                Accumulator = 0;
                throw new ArgumentException("Divide by zero");
            }
                
            Accumulator = divident / divisor;
            return Accumulator;
        }

        public double Accumulator { get; private set; } = 0;

        public void Clear()
        {
            Accumulator = 0;
        }
    }

}
