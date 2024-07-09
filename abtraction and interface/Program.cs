using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abtraction_and_interface
{
    abstract class math
    {
        public abstract void add();
        public abstract void subtract();
        public abstract void multiply();
        public abstract void divide();
        public void a()
        {
            Console.WriteLine("Normal method");
        }
    }

    class values : math
    {
        public override void add()
        {
           Console.WriteLine("A+B");
        }
        public override void subtract()
        {
            Console.WriteLine("A-B");
        }
        public override void multiply()
        {
            Console.WriteLine("A*B");
        }
        public override void divide()
        {
            Console.WriteLine("A/B");
        }
        public void b()
        {
            Console.WriteLine("Child normal method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            math mathfunction = new values();
            mathfunction.add();
            mathfunction.subtract();
            mathfunction.multiply();
            mathfunction.divide();
            mathfunction.a();
            //mathfunction.b(); //does nt call directly child mathods through instance because its abstract class
        }
    }
}
