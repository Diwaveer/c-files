using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        private int Id;
        private string Name;

        public int ID
        {
           get { return Id; }
           set { Id = value; }

        }
        public string NAME
        {
            get { return Name; }
            set
            {
                if (value =="Diwa" && Id ==100)
                {
                    Console.WriteLine("Enter a value to set for Name variable is  :");
                    string setvalue =Console.ReadLine();
                    Name = setvalue;
                }
                else
                {
                    Console.WriteLine("Aunthentication is Fail");
                }
            }

        }
        static void Main(string[] args)
        {
            

            Program pro = new Program();

            Console.WriteLine("Enter a Id to auntheticate  :");
            pro.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a name to auntheticate  :");
            pro.NAME = Console.ReadLine();

            Console.WriteLine("after getting aunthetication Name value is :" + pro.Name);
        }
    }
}
