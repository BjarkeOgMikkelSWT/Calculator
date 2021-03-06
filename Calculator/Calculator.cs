﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hand_Testing_Calculator
{
    public class Calculator
    {
        public double Accumulator { get; private set; } = 0;
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Add(double a)
        {
            return Add(a, Accumulator);
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Subtract(double a)
        {
            return Subtract(Accumulator,a);
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Multiply(double a)
        {
            return Multiply(a, Accumulator);
        }

        public double Power(double a, double exp)
        {
            Accumulator = Math.Pow(a, exp);
            return Accumulator;
        }

        public double Power(double exp)
        {
            return Power(Accumulator, exp);
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

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Divide(double divisor)
        {
            return Divide(Accumulator, divisor);
        }

        public double Modulo(double a, double mod)
        {
            Accumulator = a % mod;
            return Accumulator;
        }

        public double Modulo(double mod)
        {
            return Modulo(Accumulator, mod);
        }

        public double Root(double a,int root)
        {
            if(a < 0||root < 0)
            {
                throw new ArgumentException("Root function got negative input");
            }
            else if(root == 0)
            {
                throw new ArgumentException("Root is zero so dividing by zero");
            }

            return Power(a,1.0/root);
        }

        public double Root(double root)
        {
            if (Accumulator < 0 ||root < 0)
            {
                throw new ArgumentException("Root function got negative input");
            }
            else if (root == 0)
            {
                throw new ArgumentException("Root is zero so dividing by zero");
            }

            return Power(Accumulator,1/root);
        }
    }

}
