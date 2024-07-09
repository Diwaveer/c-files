using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Data_type
{
    internal class Program
    {
       // private static object convert;

        static void Main(string[] args)
        {
            int pass = 3110;
           
                Console.WriteLine("enter a password");
                int userinout = int.Parse(Console.ReadLine());
            if (userinout == pass)
            {
                do
                {
                    Console.WriteLine("1.One\n2.Two\n3.Three\n4.Four\n5.Five.");
                    Console.WriteLine("Enter your choice :");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("selected 1st catagory succesfully.");
                            break;
                        case 2:
                            Console.WriteLine("selected 2nd catagory succesfully.");
                            break;
                        case 3:
                            Console.WriteLine("selected 3rd catagory succesfully.");
                            break;
                        case 4:
                            Console.WriteLine("selected 4th catagory succesfully.");
                            break;
                        case 5:
                           // Console.WriteLine("selected 5th catagory succesfully.");
                            return;
                    }
                }while (false);
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
            












            //implicit casting
            //char d = 'd';
            //int a = d;
            //long c = a;
            //float f = c;
            //double v = f; 
            
            //Console.WriteLine(v.GetType());
           

            //explicit casting
            //float v1 = (float)v;
            //long c1 = (long)v1;
            //int a1 = (int)c1;
            //char d1 = (char)a1;
            //Console.WriteLine(d1.GetType());

            

            //int intValue = -1;
            //uint uintValue = (uint)intValue;
            //Console.WriteLine(uintValue);

            //type coversion
            //example

            //string Name;
            //string Department;
            //int Year;
            //byte Mark1;
            //byte Mark2;
            //byte Mark3;
            //float Totalmark;
            //int Average;
            //string Result;

            //Console.Write("Enter the Name:");
            //Name= Console.ReadLine();

            //Console.Write("Enter the Department:");
            //Department= Console.ReadLine();

            //Console.Write("Enter the Year:");
            //Year = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the Mark1:");
            //Mark1 = Convert.ToByte(Console.ReadLine());

            //Console.Write("Enter theMmark2:");
            //Mark2 = Convert.ToByte(Console.ReadLine());

            //Console.Write("Enter the Mark3:");
            //Mark3 = Convert.ToByte(Console.ReadLine());

            //Console.Write("Enter the ToatalMark:");
            //Totalmark = Convert.ToSingle(Console.ReadLine());

            //Console.Write("Enter the Average:");
            //Average = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the Result:");
            //Result = Convert.ToString(Console.ReadLine());


            //Console.WriteLine("Name         : " + Name);      
            //Console.WriteLine("Department   : " + Department);      
            //Console.WriteLine("Year         : " + Year);      
            //Console.WriteLine("Mark1        : " + Mark1);      
            //Console.WriteLine("Mark2        : " + Mark2);      
            //Console.WriteLine("Mark3        : " + Mark3);      
            //Console.WriteLine("Totalmark    : " + Totalmark);      
            //Console.WriteLine("Average      : " + Average);
            //Console.WriteLine("Result       : " + Result);

            //Console.ReadLine();












        }
    }
}
