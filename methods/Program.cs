using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           
            double myinput = 10.342;
            double fract = 0;
            int wholenumber;
            Console.WriteLine(myinput);
            wholenumber = getfractandwholenumber(myinput,out fract);
            Console.WriteLine("whole no.is :" + wholenumber);
            Console.WriteLine("fractional number is :"+fract);
            Console.ReadKey();

        }
        public static int getfractandwholenumber (double input,out double fract)
        {
           
            fract = input - (int)input;
            return (int)input;
        }
        public static void getfractandwholenumber(int input,out int wholeno,out double fraction)
        {
            wholeno = (int)input;
            fraction = input - wholeno;
            Console.WriteLine(wholeno);

        }
    }
}
