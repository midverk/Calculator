using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calculator
    {
        public double Add(double x, double y)
        {
            return (x + y);
        }
        public double Substract(double x, double y)
        {
            return (x - y);
        }
        public double Multiply(double x, double y)
        {
            return (x * y);
        }
        public double Divide(double x, double y)
        {
            return (x / y);
        }
        public double Power(double x, double y)
        {
            double res = x;
            if (y == 0)
            {
                res = 1;
            }
            else if (y == 1)
            {
                return res;
            }
            else
            {
                for (int i = 1; i < y; i++)
                {
                    res *= x;
                }
            }
            return res;
        }
        public int Factorial(int x)
        {
            int result = 1;
            if(x == 0)
            {
                result = 1;
            }
            else
            {
                for(int i = 1; i <= x; i++)
                {
                    result *= i;
                }
            }
            return result;
        }
    }
}
