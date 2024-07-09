using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_trail.cs
{
    using System;

    class Calculator
    {
        static void Main(string[] args)
        {
            bool keepCalculating = true;

            while (keepCalculating)
            {
                Console.WriteLine("Enter the first number (or 'q' to quit): ");
                string input1 = Console.ReadLine();

                if (input1.ToLower() == "q")
                {
                    keepCalculating = false;
                    continue;
                }

                double num1;
                if (!double.TryParse(input1, out num1))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                Console.WriteLine("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the operation (+, -, *, /): ");
                char operation = Convert.ToChar(Console.ReadLine());

                double result = 0;
                bool validOperation = true;

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
                        result = Divide(num2, num1); // Division by zero check in Divide function
                        break;
                    default:
                        validOperation = false;
                        Console.WriteLine("Invalid operation!");
                        break;
                }

                if (validOperation)
                {
                    Console.WriteLine("Result: " + result);
                }

                Console.WriteLine("Do you want to perform another calculation? (y/n)");
                string continueInput = Console.ReadLine().ToLower();
                keepCalculating = continueInput == "y";
            }

            Console.WriteLine("Thank you for using the calculator!");
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

        static double Divide(double dividend, double divisor) // Changed order for division by zero check
        {
            if (divisor == 0)
            {
                Console.WriteLine("Cannot divide by zero!");
                return double.NaN;
            }
            return dividend / divisor;
        }
    }

}