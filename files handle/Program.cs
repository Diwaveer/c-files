using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace files_handle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream n = new FileStream("C:\\Users\\Administrator\\Desktop\\New folder\\Diwa.txt", FileMode.OpenOrCreate);

            n.WriteByte(65);
            for (int i = 65; i <= 91; i++)
            {


                n.WriteByte((byte)i);
            }
            //Console.WriteLine();


            //StreamWriter w = new StreamWriter(n);

            //string d = "This is a string";
            //for (int i = 1; i < 5; i++)
            //{

            //    //d = Console.ReadLine();
            //    w.WriteLine(d);

            //}
            //w.Close();

            StreamReader r = new StreamReader(n);
            string s;
            while ((s = r.ReadLine()) != null)
            {

                Console.WriteLine(s);
            }
            r.Close();
            n.Close();
        }
    }
}
