using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

///------------------------------------------ATM----------------------------
namespace functions.cs
{
    /* class ATMSystem
     {
        /* static bool continueATM = true;
         static bool isAuthenticated = false;

         static void Main(string[] args)
         {
             while (continueATM)
             {
                 if (!isAuthenticated)
                 {
                     Console.Write("Enter Your 4 Digit ATM PIN Number: ");
                     int pin = int.Parse(Console.ReadLine());

                     if (ValidatePIN(pin))
                     {
                         isAuthenticated = true;
                         ShowMenu();
                     }
                     else
                     {
                         Console.WriteLine("Incorrect PIN. Please try again later.");
                     }
                 }
                 else
                 {
                     int choice = int.Parse(Console.ReadLine());
                     continueATM = ProcessChoice(choice);
                 }
             }
         }
         static bool ValidatePIN(int pin)
         {
             // Assuming the correct PIN is 1122 (replace with actual PIN storage/verification)
             return pin == 1122;
         }

         static void ShowMenu()
         {
             Console.WriteLine("1. Account Details");
             Console.WriteLine("2. Account Balance");
             Console.WriteLine("3. Mini Statement");
             Console.WriteLine("4. Exit");
         }

         static bool ProcessChoice(int choice)
         {
             switch (choice)
             {
                 case 1:
                     ShowAccountDetails();
                     return true;
                 case 2:
                     ShowAccountBalance();
                     return true;
                 case 3:
                     ShowMiniStatement();
                     return true;
                 case 4:
                     Exit();
                     return false;
                 default:
                     Console.WriteLine("Invalid choice.");
                     return true;
             }
         }

         static void ShowAccountDetails()
         {
             Console.WriteLine("Account Details: A/C Number: 6425678050, Branch: Indian Bank, Place: T.palur, IFSC: B000T116.");
         }

         static void ShowAccountBalance()
         {
             int oldAmount = 50000;
             int creditedAmount = 25000;
             int totalBalance = oldAmount + creditedAmount;
             Console.WriteLine("Balance Amount: " + totalBalance);
         }
         static void ShowMiniStatement()
         {
             Console.WriteLine("1. UPI scan @ Mumbai chai $25, 2. Salary credited &25000!");
         }

         static void Exit()
         {
             isAuthenticated = false; // Reset authentication for next session
             Console.WriteLine("Thank you for visiting!");
         } */


}



    class Program
    {
        static void Main(string[] args)
        {
            // Initial balance
            double balance = 1000;

            Console.WriteLine("Welcome to the ATM");

            // Withdraw some money
            Withdraw(ref balance);

            // Check balance
            CheckBalance(balance);

            // Deposit some money
            double depositAmount;
            Deposit(ref balance, out depositAmount);

            // Check balance again
            CheckBalance(balance);
            Console.WriteLine($"Thank you for depositing {depositAmount:C2}.");
            Console.WriteLine("Thank you for using the ATM");
        }

        static void Withdraw(ref double balance)
        {
            double amount;
            Console.Write("Enter the amount to withdraw: ");
            if (double.TryParse(Console.ReadLine(), out amount))
            {
                if (balance >= amount)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdraw successful. Current balance: {balance}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        static void Deposit(ref double balance, out double depositAmount)
        {
            double amount;
            Console.Write("Enter the amount to deposit: ");
            if (double.TryParse(Console.ReadLine(), out amount))
            {
                balance += amount;
                depositAmount = amount;
                Console.WriteLine($"Deposit successful. Current balance: {balance}");
            }
            else
            {
                Console.WriteLine("Invalid input");
                depositAmount = 0;
            }
        }

        static void CheckBalance(double balance)
        {
            Console.WriteLine($"Current balance: {balance}");
        }
    }
