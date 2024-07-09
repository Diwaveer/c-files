using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_ATM_DETAILS
{
    
    public abstract class Account
    {
        public int AccountNumber { get; private set; }

        public Account(int accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public abstract decimal Balance { get; }

        public abstract bool Deposit(decimal amount);

        public abstract bool Withdraw(decimal amount);

        public abstract void DisplayBankDetails();
    }

    public class SavingsAccount : Account
    {
        private decimal balance;

        public SavingsAccount(int accountNumber, decimal initialBalance) : base(accountNumber)
        {
            balance = initialBalance;
        }

        public override decimal Balance => balance;

        public override bool Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return false;
            }

            balance += amount;
            return true;
        }

        public override bool Withdraw(decimal amount)
        {
            if (amount <= 0 || balance - amount < 0)
            {
                return false;
            }

            balance -= amount;
            return true;
        }

        public override void DisplayBankDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Type: Savings");
            Console.WriteLine($"Balance: {Balance:C}");
        }
    }

    public class ATM
    {
        private Account account;

        public ATM(Account account)
        {
            this.account = account;
        }

        public void Run()
        {
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("\nATM Menu");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Display Bank Details");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Your current balance is: {account.Balance:C}");
                        break;
                    case 2:
                        decimal depositAmount;
                        Console.Write("Enter amount to deposit: ");
                        depositAmount = Convert.ToDecimal(Console.ReadLine());

                        if (account.Deposit(depositAmount))
                        {
                            Console.WriteLine($"Deposit successful. New balance: {account.Balance:C}");
                        }
                        else
                        {
                            Console.WriteLine("Deposit failed. Please enter a valid amount.");
                        }
                        break;
                    case 3:
                        decimal withdrawAmount;
                        Console.Write("Enter amount to withdraw: ");
                        withdrawAmount = Convert.ToDecimal(Console.ReadLine());

                        if (account.Withdraw(withdrawAmount))
                        {
                            Console.WriteLine($"Withdrawal successful. Please collect your cash. New balance: {account.Balance:C}");
                        }
                        else
                        {
                            Console.WriteLine("Withdrawal failed. Insufficient funds or invalid amount.");
                        }
                        break;
                    case 4:
                        account.DisplayBankDetails();
                        break;
                    case 5:
                        Console.WriteLine("Thank you for using the ATM. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (choice != 5);
        }

        public static void Main(string[] args)
        {
            
            int accountNumber = 123456;
            decimal initialBalance = 1000.00m;

            SavingsAccount account = new SavingsAccount(accountNumber, initialBalance);
            ATM atm = new ATM(account);

            atm.Run();
        }
    }

}
