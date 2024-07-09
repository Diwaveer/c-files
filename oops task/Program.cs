using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_task
{

    interface  IAccount
    {
        void Deposit(double amount);
        void Withdraw(double amount);
        void Customerdetails(string name,string address,string phonenumber, double initialbalance);

    }

    class Details :IAccount
    {
        //public string Name;
        //public string Address;
        //public string Phonenumber;




        //public Details(double initialbalace)
        //{
        //    balance = initialbalace;
        //}

        public double balance;
        public void Customerdetails(string name, string address, string phonenumber,double initialbalance)
        {
            Console.WriteLine($"Name :{name}");
            Console.WriteLine($"Address :{address}");
            Console.WriteLine($"phonenumber :{phonenumber}");
            Console.WriteLine($"Initialbalance :{initialbalance}");
            this.balance = initialbalance;
        }
        public void Deposit(double amount)
        {

            balance += amount;
            Console.WriteLine($"Deposit amount :{amount},New balance :{balance}");
        }
        public void Withdraw(double amount)
        {
            if (balance >amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn amount :{amount},New balance :{balance}");
            }
            else
            {
                Console.WriteLine("Insufficiant funds");
            }
            
        }
       

    }
    class ATM 
    {
        IAccount account;
        public ATM()
        {
            account = new Details();
        }
          
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
           IAccount acco = new Details();
            
            acco.Customerdetails("Diwa", "234", "222-4567787", 1000);
            acco.Deposit(500);
            acco.Withdraw(100);
        }
    }
}
