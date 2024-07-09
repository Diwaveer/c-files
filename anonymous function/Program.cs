using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous_function
{
    public  delegate void Method();
    public class DOOD
    {
        public static void Mymethod()
        {
            Console.WriteLine("It is a anonymous delegate");
        }
        public static void Mymethod2()
        {
            Console.WriteLine("Its second method");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            //Method m = new Method(DOOD.Mymethod);
            //m();
            //Method m1 = new Method(DOOD.Mymethod2);
            //m1();


            Method mm = delegate 
            {
                Console.WriteLine("It is a anonymous delegate");

            };
            mm();
            Action<int, string> s1 = (a, d) =>
            {
                Console.WriteLine("123");
                Console.WriteLine("466");
                Console.WriteLine("5678");
            };
            s1(23, "dd");
            Func<int, int, float, double, string> s2 = (c, e, y, g) =>
            {
                Console.WriteLine("dhfgghjg");
                Console.WriteLine("fghdhmfgnjv");
                return "d";
            };
            s2(2, 4, 1.2f, 3.53);
             

        }
    }
}
