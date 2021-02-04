using System;

namespace Hand_Testing_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Add 5 + 3: {0}", calc.Add(5,3));
            Console.WriteLine("Sub -3 - 7: {0}", calc.Subtract(-3,7));
            Console.WriteLine("Multiply 42 x 69: {0}", calc.Multiply(42, 69));
            Console.WriteLine("Test of 2 to the power of 7: {0}", calc.Power(2, 7));
        }
    }
}
