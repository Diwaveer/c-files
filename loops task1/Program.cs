using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Write a C# Sharp program to calculate the factorial of a given number
            /*int num, f = 1;
            Console.WriteLine("Enter a Number ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=num; i++)
            {
                f *= i;
            }
            Console.WriteLine("The Factorial of given Num is  :" + " " + f); */

            // 2. Write a C# Sharp program to find the sum of the first 10 natural numbers
            /* int n, i, sum = 0;
             Console.WriteLine("Enter a posotive number :");
             n = Convert.ToInt32(Console.ReadLine());
             for (i = 1; i <=n; i++)
             {
                 sum = sum + i;
             }
             Console.WriteLine("The sum of numbers = " + sum); */

            // 3. Write a C# Sharp program to read 10 numbers and find their average and sum.
             /* int i, n, sum = 0;  // Declaration of variables 'i' for iteration, 'n' to store each number, and 'sum' to store their total sum
             double avg;  // Declaration of variable 'avg' to store the average

             Console.Write("\n\n"); 
             Console.Write("Read 10 numbers and calculate sum and average:\n"); 
             Console.Write("----------------------------------------------");  
             Console.Write("Input the 10 numbers : \n");  
             for (i = 1; i <= 10; i++)  
             {
                 Console.Write("Number-{0} :", i);  

                 n = Convert.ToInt32(Console.ReadLine());  
                 sum += n;  
             }
             avg = sum / 10.0;
             Console.Write("The sum of the numbers : "+ sum);
             Console.Write("\n\n");
             Console.Write("The  average is :"+avg); 
            Console.ReadKey(); */

            // 4. Write a C# Sharp program to display the cube of an integer up to given number.

             int cube = 1;
             Console.WriteLine("Enter a Number ");
             int num = Convert.ToInt32(Console.ReadLine());

             for (int i = 0; i < 3; i++)
             {
                    cube *= num;               
             }
            Console.WriteLine("The cube value is  :"+cube); 

            // 5. Write a program in C# Sharp to display the multiplication table of a given integer

            /* Console.WriteLine("Enter a Table number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the multiplication table limit : ");
            int limit = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Multiplication table of {0} up to {1}:", number, limit); //{0} ,{1} are placeholders & number and limit are the values to place in the placeholder

            for (int i = 1; i <= limit; i++)
            {
                int product = number * i;
                Console.WriteLine("{0} x {1} = {2}", i, number, product);
            } */

            // 6.  Write a program in C# Sharp to display a right angle triangle with an asterisk
            //Example 1:

            /* Console.WriteLine("Enter the number of rows for the triangle: ");
           int rows = Convert.ToInt32(Console.ReadLine());

           for (int i = 1; i <= rows; i++)
           {
               for (int j = 1; j <= i; j++)
               {
                   Console.Write("*");
               }
               Console.WriteLine();
           } */
            //Example 2: To make an pyramid

            /* int n,x,y,z;
            Console.WriteLine("Enter the no.of rows :");
            n = Convert.ToInt32(Console.ReadLine());
            for(x = 1;x <= n;x++)
            {
                for (y = 1;y <= n-x;y++)
                {
                    Console.Write(" ");
                }
                for (z = 1;z <= x;z++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine() ;
            } */

            // 7. Write a program in C# Sharp to display a pattern like a right angle triangle with a number

            /* Console.WriteLine("Enter the number of rows for the triangle: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(); // Move to the next line after each row
            } */

            // 8. Write a program in C# Sharp to make such a pattern like a right angle triangle with a number orderly

            /* Console.WriteLine("Enter the number of rows for the triangle: ");
           int rows = Convert.ToInt32(Console.ReadLine());

           int number = 1;
           for (int i = 1; i <= rows; i++)
           {
               for (int j = 1; j <= i; j++)
               {
                   Console.Write(number + " ");
                   number++;
               }
               Console.WriteLine(); // Move to the next line after each row
           } */


            // 9.Write a C# Sharp program to make such a pattern like a right angle triangle with
            // the number increased by 1

            /* Console.WriteLine("Enter the number of rows for the triangle: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            int Num = 1;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(Num++);
                }
                Console.WriteLine(); // Move to the next line after each row
                Num++; // Increment starting number for the next row
            } */

            //10. Write a program in C# Sharp to display the pattern like a diamond

            /* Console.Write("Enter the number of rows for the diamond: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            int count = 1;

            // Upper part of the diamond
            for (int i = 1; i <= rows; i++)
            {
                // Print spaces before asterisks
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                // Print asterisks
                for (int k = 1; k <= count; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); // Move to the next line after each row
                count += 2; // Increase count by 2 for wider rows in the upper part
            }

            count -= 4; // Adjust count for the lower part

            // Lower part of the diamond (excluding the last row, which is the mirror of the first row)
            for (int i = rows - 1; i >= 1; i--)
            {
                // Print spaces before asterisks
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                // Print asterisks
                for (int k = 1; k <= count; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); // Move to the next line after each row
                count -= 2; // Decrease count by 2 for narrower rows in the lower part
            } */

            // square root of given no.

           /* int a = 4;
            for (int i = 0; i < a; i++) 
            {
                int k = a;
                int j = i;
                while (j > 0) 
                {
                    k -=i;
                    j--;
                }
                if (k == 0)
                {
                    Console.WriteLine("Square root of : {0) : is : {1}" + a, i);
                }
                else if (k <0)
                {
                    Console.WriteLine("Not found");
                }
                              

            } */


        }
    }
}
