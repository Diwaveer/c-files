using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refout_demo
{
    internal class Refoutdemo
    {
        public int Addition(ref int a , out int b)
        {
            
            b=20; 
            return a+b;
        }
        static void Main(string[] args)
        {
            int b = 5;
            Console.WriteLine("The value of b before calling method is :" +b);

            Refoutdemo rodemo = new Refoutdemo();
            int x = 10;
           // int b = 60;
            

            Console.WriteLine(rodemo.Addition(ref x, out b));

            Console.WriteLine("Current value of a :" + x);
            Console.WriteLine("The value of b after calling method is :" + b);
        }
    }
}
