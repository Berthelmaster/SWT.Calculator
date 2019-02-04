using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;


namespace Calculator
{
    public class Calculator
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
 
        }

        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Division(int num1, int num2)
        {
            return num1 / num2;
        }

        public double Power(int num1)
        {
            return Math.Pow(num1, 2);
        }

        // THIS IS A TEST
        // THIS IS A TEST2

        

        public double Divide(double divided, double divisor)
        {
            if (divisor == 0)
                throw new System.DivideByZeroException();
            return divided / divisor;
        }

        public static void Main()
        {
        }
    }

}

