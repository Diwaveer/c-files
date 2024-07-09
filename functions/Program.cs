using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    internal class Program
    {
        class Calculator
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the operation (+, -, *, /): ");
                char operation = Convert.ToChar(Console.ReadLine());

                double result = 0;

                switch (operation)
                {
                    case '+':
                        result = Add(num1, num2);
                        break;
                    case '-':
                        result = Subtract(num1, num2);
                        break;
                    case '*':
                        result = Multiply(num1, num2);
                        break;
                    case '/':
                        result = Divide(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid operation!");
                        return;
                }

                Console.WriteLine("Result: " + result);
            }

            static double Add(double a, double b)
            {
                return a + b;
            }

            static double Subtract(double a, double b)
            {
                return a - b;
            }

            static double Multiply(double a, double b)
            {
                return a * b;
            }

            static double Divide(double a, double b)
            {
                if (b == 0)
                {
                    Console.WriteLine("Cannot divide by zero!");
                    return double.NaN;
                }
                return a / b;
            }

        }
    }
}



        
    
        
