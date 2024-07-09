using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace person_bank_details
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pass = 3110;
            Console.WriteLine("Enter a password");
            int a = int.Parse (Console.ReadLine());     
            if (pass ==a)
            {
                Console.WriteLine("what do you want");
                Console.WriteLine("1:Account holder infroamtion");
                Console.WriteLine("2:Bank balance");
                Console.WriteLine("3:Withdrawl details");
                Console.WriteLine("4:Depasit details");
                int b = int.Parse (Console.ReadLine());
                switch (b)
                {
                    case 1:
                        Console.WriteLine("Enter the Account holder's name :");
                        Console.WriteLine("Enter the Account holder's phone no. :");
                        Console.WriteLine("Enter the Account holder's native :");
                        Console.WriteLine("Enter the holder's bank branch");
                        break;
                     case 2:
                        Console.WriteLine("");
                        Console.WriteLine("Enter the Account number :");
                        Console.WriteLine("Enter the bank balance");
                        break;
                        case 3:
                        Console.WriteLine("Enter the ATM city :");
                        Console.WriteLine("Enter the Withdrawl amount :");
                        break;
                        case 4:
                        Console.WriteLine("Enter the Account number :");
                        Console.WriteLine("Enter the deposit amount :");
                        break ;
                        default:
                        Console.WriteLine("Enter your correct details.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Enter your correct password.");
            }
        }
    }
}
