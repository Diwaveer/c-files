using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm_overriide_task
{
    internal class Program
    {
        public class ATMdeposit
        {
            public virtual void Atmfunction( double amount)
            {
                Console.WriteLine("Enter the Account number :");
                Console.WriteLine("Enter the deposit amount :");

            }
        }
        public class ATMwithdraw:ATMdeposit
        {
            public override void Atmfunction(double amount) 
            {
                Console.WriteLine("Enter the ATM city :");
                Console.WriteLine("Enter the Withdrawl amount :");
            }           
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 ")
          int atmtype = int.Parse(Console.ReadLine());
            switch (atmtype)
            {
                case 1:
                    ATMdeposit ATMwithdraw = new ATMwithdraw();
                    ATMwithdraw.Atmfunction();

            }
               
               
        }
    }
}
