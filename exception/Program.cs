using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    public class VoteAgeLimit : ApplicationException
    {
        public VoteAgeLimit(string message) : base(message)
        {
        }
    } 
    
    public class voterCheck
    {
        private int age;
        public void votelimt(int age)
        {
            if (age < 18)
            {
                throw new VoteAgeLimit("You are not eligible to vote. Minimum age required is 18 years.");
            }
            else
            {
                Console.WriteLine("Vote cast successfully!");
            }

            this .age = age;    
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //SYSTEM EXCEPTIONS:

            //Console.WriteLine("Start of the application");
            //Console.WriteLine("start of the arithematic function");
            //Console.WriteLine("Declare a array values");
            //int[] a = { 1, 2, 3 };
            //for (int i  = 0; i < a.Length; i++)
            //{

            //    try
            //    {
            //         int a = int.Parse(Console.ReadLine());
            //         Console.WriteLine("Enter a second value");
            //         int b = int.Parse(Console.ReadLine());
            //         int c = a * b;
            //         Console.WriteLine("THe output value is   :" + c);
            //         Console.WriteLine("End of the arithemaic function");*/

            //        for (int i = 0; i < 10; i++)
            //        {
            //            Console.WriteLine(a[i]);
            //        }
            //    }
            //    catch(Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //}
            /* catch(DivideByZeroException) 
             {
                 Console.WriteLine("Your value doesnt divide by zero");
             }
             catch(FormatException)
             {
                 Console.WriteLine("Your value doesnt correct with a type");
             }
             catch(OverflowException d)
             {
                 Console.WriteLine("your value type is bigger than needed value type  :"+d.Message);
             }
             catch(Exception e)
             {
                 Console.WriteLine(e.Message);
             }
             finally
             {
                 Console.WriteLine("If any exception may occur ,finally code should always be excecute");
             }*/

            // Console.WriteLine("End of the Application ");


            //APPLICATION EXCEPTIONS:

            Console.WriteLine("Enter you age:");
            int age = int.Parse(Console.ReadLine());
            voterCheck Voter = new voterCheck();
            Voter.votelimt(age);

        }

    }

}