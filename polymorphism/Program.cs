using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Program
    {
        //1.over loading polymorphism
        //public void add()
        //{
        //    Console.WriteLine("Method 1 add");
        //}
        //public void add(int a ,int b)
        //{
        //    Console.WriteLine(a+b);
        //}
        //public void add(int a ,int b,int c)
        //{
        //    Console.WriteLine(a+b+c);
        //}

        //2.over riding polymorphism
        public class A
        {
            public void a()
            {
                Console.WriteLine("without parameter");
            }
            public virtual void b(int d)
            {
                Console.WriteLine("method with int parameter  : " + d);
            }
            public void c(string c)
            {
                Console.WriteLine("method with string parameter  :" + c);
            }
        }
        class B:A
        {
            public override void b(int d)
            {
                Console.WriteLine("first child method parameter   :" + d);
                base.b(d);
            }
        }
        class C : B
        {
            public override void b(int d)
            {
                Console.WriteLine("second child method parameter   :" + d);
                base.b(7);
            }
        }
        static void Main(string[] args)
        {
            /* Program program = new Program();
            program.add();
            program.add(6,3);
            program.add(13,4); */

            A f =new A();
            f.a();
            f.b(3);
            f.c("Diwa");
            f = new B();
            f.b(5);
            f = new C();
            f.b(6);
        }
    }
}
