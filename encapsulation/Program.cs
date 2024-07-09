using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    internal class Program
    {
        public int ID ;
        public string Name;
        public string Description;

        //DIRECTLY CALL
       // public int MyProperty {  get; private set; }
        
        //through method
        public int getId()
        { 
            return ID;
        }
        public void setId(int a)
        {
            ID = a;
        }

        //set of property field
        public string NAME
        {
            get { return Name; }
            set
            {
                if (value != null && ID == 100)
                {
                    Name = value;
                }
            }
        }
        //public void Add()
        //{
        //    Console.WriteLine("The value of name :" + Name);
        //}

        static void Main(string[] args)
        {
            Program pro = new Program();
            // pro.Add();

            //Console.WriteLine("The value is  :" + pro.getId());

            //Console.WriteLine("Enter a value a rewrite to ID ");
            //int a = int.Parse(Console.ReadLine());
            //pro.setId(a);

            //Console.WriteLine("After rewrite a value to ID");
            //Console.WriteLine("The value is :" + pro.getId());

            //Console.WriteLine("The name is :" + pro.NAME);

            //Console.WriteLine("enter a ID  number is :");
            //int ID = int.Parse(Console.ReadLine());

            //Console.WriteLine("\n\nEnter a name");
            //pro.NAME = Console.ReadLine();
            //Console.WriteLine("After rewrite the name is :" + pro.NAME);

            Console.WriteLine("Enter a Id to auntheticate  :");
            pro.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a name to auntheticate  :");
            pro.Name = Console.ReadLine();
            Console.WriteLine("after getting aunthetication Name value is :" + pro.Name);

            //pro.Add();

            //Console.WriteLine(pro.MyProperty);
            //Console.WriteLine("Set a value to ID is :");
            //pro.ID =int.Parse(Console.ReadLine());
            //Console.WriteLine("The Id is :"+pro.ID);


        }
    }
}
