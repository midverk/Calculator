using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator Math = new Calculator();
            double add = Math.Add(3, 4);
            double Sub = Math.Substract(3, 4);
            double Mul = Math.Multiply(3, 4);
            double Div = Math.Divide(3, 4);
            double Pow = Math.Power(3, 0);
            int Fact = Math.Factorial(5);

            Console.WriteLine(add);
            Console.WriteLine(Sub);
            Console.WriteLine(Mul);
            Console.WriteLine(Div);
            Console.WriteLine(Pow);
            Console.WriteLine(Fact);
        }
    }
}
