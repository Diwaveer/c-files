using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditions_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            int year;
            int age;

            //1.CHECK TWO INTEGERS WHETHER IT IS SAME OR NOT

            Console.WriteLine("Enter the first integer :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second integer :");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("The two integers are equal.");
            }
            else
            {
                Console.WriteLine("The two integers are not equal.");
            }

            //2.CHECK WHETHER A GIVEN NUMBER IS EVEN OR ODD

            Console.WriteLine("Enter a number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 % 2 == 0)
            {
                Console.WriteLine("The given no.is even");
            }
            else
            {
                Console.WriteLine("The given no.is odd");
            }

            //3.CHECK WHETHER A GIVEN NUMBER IS POSITIVE OR NEGATIVE

            Console.WriteLine("Enter a number :");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (num1 < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            //4.CHECK WHETHER A GIVEN YEAR IS LEAP YEAR OR NOT

            Console.WriteLine("Enter a year :");
            year = Convert.ToInt32(Console.ReadLine());
            if (((year % 4) == 0) || (year % 400 == 0))
            {
                Console.WriteLine("The given year is leap year");
            }
            else
            {
                Console.WriteLine("The given is not leap year");
            }

            //5.DETERMINE WHETHER A CANDIDATE IS ELIGIBLE TO VOTE BASED ON THEIR AGE

            Console.WriteLine("Enter the candidate's age :");
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Candidate eligible for vote");
            }
            else
            {
                Console.WriteLine("Candidate not eligible for vote");
            }

            //6.FIND THE LARGEST OF THREE NUMBERS

            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            num3 = Convert.ToInt32(Console.ReadLine());

            int largest = num1;

            if (num2 > largest)
            {
                largest = num2;
            }

            if (num3 > largest)
            {
                largest = num3;
            }
            Console.WriteLine("The largest number is: " + largest);

            //7.CALCULATE PROFIT AND LOSS ON A TRANSACTION

            Console.WriteLine("Enter the cost price:");
            double costPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the selling price:");
            double sellingPrice = Convert.ToDouble(Console.ReadLine());

            if (sellingPrice > costPrice)
            {
                double profit = sellingPrice - costPrice;
                Console.WriteLine("Profit: " + profit);
            }
            else if (sellingPrice < costPrice)
            {
                double loss = costPrice - sellingPrice;
                Console.WriteLine("Loss: " + loss);
            }
            else
            {
                Console.WriteLine("No profit, no loss.");
            }

            //READ A MONTH NUMBER AND DISPLAY THE MONTH NAME

            Console.WriteLine("Enter the month number:");
            int monthNumber = Convert.ToInt32(Console.ReadLine());

            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Invalid month number.");
                    break;
            }

            //11.check whether a triangle can be formed by the given angles

            Console.WriteLine("Enter the three angles of the triangle:");
            int angle1 = Convert.ToInt32(Console.ReadLine());
            int angle2 = Convert.ToInt32(Console.ReadLine());
            int angle3 = Convert.ToInt32(Console.ReadLine());

            if (angle1 + angle2 + angle3 == 180)
            {
                Console.WriteLine("Triangle can be formed with the given angles.");
            }
            else
            {
                Console.WriteLine("Triangle cannot be formed with the given angles.");
            }

        }
    }
}
