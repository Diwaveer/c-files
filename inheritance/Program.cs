using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        // Hierachichal inheritance
      /* public class principal
        {
            public void Monitor()
            {
                Console.WriteLine("Monitor");
            }
        }
        public class teacher : principal
        {
            public void Teach()
            {
                Console.WriteLine("Teach");
            }
        }
        public class Student : principal 
        {
            public void learn()
            {
                Console.WriteLine("learn");
            }
        } */
        static void Main(string[] args)
        {
            //Hierachichal inheritance
           /* principal p = new principal();
            p.Monitor();

            teacher t = new teacher();
            t.Teach();  

            Student s = new Student();
            s.learn();
            s.Monitor(); */

            //multilevel inheritance

            Son s = new Son();
            s.display1();
            s.display2();
            s.display3();
            Console.ReadLine();
        } 

        //multilevel inheritance

        public class GrandFather
        {
            public void display1()
            {
                Console.WriteLine("GrandFather....");
            }
        }
        public class Father : GrandFather
        {
            public void display2()
            {
                Console.WriteLine("Father....");
            }
        }
        public class Son : Father
        {
            public void display3()
            {
                Console.WriteLine("Son....");
            }
        }

    } 
}
