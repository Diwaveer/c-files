using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_atm_task
{
    class ATM
    {
        private double balance;
        private string bankName;
        private string accountNumber;
        private bool isManager;

        public ATM(string bankName, string accountNumber, bool isManager)
        {
            this.bankName = bankName;
            this.accountNumber = accountNumber;
            balance = 0;
            this.isManager = isManager;
        }

        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public string BankName
        {
            get { return bankName; }
        }

        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public bool IsManager
        {
            get { return isManager; }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited ${amount}. New balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn ${amount}. New balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Current balance: ${balance}");
        }

        public void BankDetails()
        {
            Console.WriteLine($"Bank Name: {bankName}\nAccount Number: {accountNumber}");
        }

        // Manager specific method
        public void ManagerInformation(string managerName)
        {
            if (isManager)
            {
                Console.WriteLine($"Manager Information:\nName: {managerName}");
            }
            else
            {
                Console.WriteLine("You are not authorized to view manager information.");
            }
        }

        // Employee specific method
        public void EmployeeInformation(string employeeName)
        {
            if (!isManager)
            {
                Console.WriteLine($"Employee Information:\nName: {employeeName}");
            }
            else
            {
                Console.WriteLine("You are not authorized to view employee information.");
            }
        }

        // Customer specific method
        public void CustomerInformation(string customerName)
        {
            Console.WriteLine($"Customer Information:\nName: {customerName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM("MyBank", "1234567890", false);

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nATM Menu:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Bank Details");
                Console.WriteLine("5. Manager Information");
                Console.WriteLine("6. Employee Information");
                Console.WriteLine("7. Customer Information");
                Console.WriteLine("8. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter deposit amount: $");
                        double depositAmount = double.Parse(Console.ReadLine());
                        atm.Deposit(depositAmount);
                        break;
                    case 2:
                        Console.Write("Enter withdrawal amount: $");
                        double withdrawalAmount = double.Parse(Console.ReadLine());
                        atm.Withdraw(withdrawalAmount);
                        break;
                    case 3:
                        atm.CheckBalance();
                        break;
                    case 4:
                        atm.BankDetails();
                        break;
                    case 5:
                        atm.ManagerInformation("John Doe");
                        break;
                    case 6:
                        atm.EmployeeInformation("Jane Doe");
                        break;
                    case 7:
                        atm.CustomerInformation("Alice");
                        break;
                    case 8:
                        exit = true;
                        Console.WriteLine("Exiting the ATM. Thank you!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
    }

}
