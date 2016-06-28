using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Calculator
    {

        public double Addition(int a, int b) {

            return (long)a + (long)b;
        }

        public int Subtraction(int a, int b) {

            return a - b;
        }

        public double Multiplication(int a, int b) {

            return (long)a * (long)b;
        }

        public double Division(int a, int b)
        {

            return (double)a / (double)b;
        }

    }
}
