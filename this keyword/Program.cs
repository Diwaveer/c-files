using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this_keyword
{
    internal class student
    {
        public int id;
        public string name;

        public student (int id, string name)
        {
            //id = id;
            //name = name;
            this.id = id;
            this.name = name;
        }

        public void Getstudent()
        {
            Console.WriteLine(id + " : " + name);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            student obj = new student(001,"Diwa");
            obj.Getstudent();
        }
    }
}
