using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalculator;
using System.Configuration;

namespace ConsoleForCalc
{
    class ConsoleForCalc
    {
        static void Main(string[] args)
        {
            //b. В консольном приложении реализовать ввод с клавиатуры двух чисел и в качестве результата
            // в консоль выдавать их сумму.Использовать Console.ReadLine/WriteLine и Int32.Parse

            
            int firstNumber, secondNumber;
            int sub;
            double sum, mult, dev;
            String check;
            bool useLibrary, useConsole;


            useConsole = Convert.ToBoolean(ConfigurationManager.AppSettings["UseConsole"]);

            if (useConsole == true)
            {
                Console.WriteLine("Enter two numbers for calculating.");

                Console.WriteLine("Enter first number: ");
                check = Console.ReadLine();
                while (!int.TryParse(check, out firstNumber))
                {
                    Console.WriteLine("You entered wrong type of data. You should enter the integer number. Try again:");
                    check = Console.ReadLine();
                }

                Console.WriteLine("Enter second number: ");
                check = Console.ReadLine();
                while (!int.TryParse(check, out secondNumber))
                {
                    Console.WriteLine("You entered wrong type of data. You should enter the integer number. Try again:");
                    check = Console.ReadLine();
                }
            }
            else {

                check = Data.FirstNumber;
                while (!int.TryParse(check, out firstNumber))
                {
                    Console.WriteLine("You have wrong type of data in resours file. You should enter the integer number.");
                    Environment.Exit(-1);
                }

              
 
                 check = Data.SecondNumber;
                while (!int.TryParse(check, out secondNumber))
                {
                    Console.WriteLine("You have wrong type of data in resours file. You should enter the integer number.");
                    Environment.Exit(-1);
                }
                Console.WriteLine($"You have two numbers for calculating in resours file. That is : a = {firstNumber} and b = {secondNumber}.");
            }
           


            useLibrary = Convert.ToBoolean(ConfigurationManager.AppSettings["UseLibrary"]);
            if (useLibrary == true)
            {
                Calculator calc = new Calculator();
                sum = calc.Addition(firstNumber, secondNumber);
                sub = calc.Subtraction(firstNumber, secondNumber);
                mult = calc.Multiplication(firstNumber, secondNumber);
                dev = calc.Division(firstNumber, secondNumber);
                Console.WriteLine($"Sum: {sum}, difference: {sub}, product: {mult}, quotient: {dev} ");
            }
            else {
                sum = Addition(firstNumber, secondNumber);
                sub = Subtraction(firstNumber, secondNumber);
                mult = Multiplication(firstNumber, secondNumber);
                dev = Division(firstNumber, secondNumber);
                Console.WriteLine($"Sum: {sum}, difference: {sub}, product: {mult}, quotient: {dev} ");

            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine(); 
            


        }


        public static double Addition(int a, int b)
        {

            return (long)a + (long)b;
        }

        public static int Subtraction(int a, int b)
        {

            return a - b;
        }

        public static double Multiplication(int a, int b)
        {

            return (long)a * (long)b;
        }

        public static double Division(int a, int b)
        {

            return (double)a / (double)b;
        }

    }
}
