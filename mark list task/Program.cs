using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mark_list_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int Pass = 35;

            //Console.Write("Enter the Tamil's mark :");
            //double Tmark = int.Parse(Console.ReadLine());
            //Console.Write("Enter the English' mark :");
            //double Emark = int.Parse(Console.ReadLine());
            //Console.Write("Enter the Maths' mark :");
            //double Mmark = int.Parse(Console.ReadLine());
            //Console.Write("Enter the Science's mark :");
            //double Smark = int.Parse(Console.ReadLine());
            //Console.Write("Enter the Social Science's mark :");
            //double SSmark = int.Parse(Console.ReadLine());


            //if (Tmark < Pass || Emark < Pass || Mmark < Pass || Smark < Pass || SSmark < Pass )
            //{
            //    Console.WriteLine("Fail");
            //    Console.WriteLine("Better Luck Next Time");
            //}
            //else if (Tmark > Pass && Emark > Pass && Mmark > Pass && Smark > Pass && SSmark > Pass )
            //{
            //    Console.WriteLine("Pass");
            //    Console.WriteLine("Good Luck");
            //}
            //else 
            //{
            //    Console.WriteLine("Study Well");
            //}









            String Name;
            int Tamil;
            int English;
            int Maths;
            int Science;
            int Socialscience;
            Console.WriteLine("Enter Your Student Name :");
            Name = Console.ReadLine();

            Console.WriteLine("Enter mark for Tamil (0-100):");
            Tamil = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter grade for English (0-100):");
            English = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter grade for Maths (0-100):");
            Maths = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter grade for Science (0-100):");
            Science = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter grade for Socialscience (0-100):");
            Socialscience = int.Parse(Console.ReadLine());

            //Tamil grade
            if ((Tamil < 0) || (Tamil > 100))
            {
                Console.WriteLine("Invalid marks.please enter a value between 0 and 100.");
                return;
            }
            else if (Tamil >= 90)
            {
                Console.WriteLine(" Tamil subject grade :A");
            }
            else if (Tamil >= 80)
            {
                Console.WriteLine(" Tamil subject grade :B");
            }
            else if (Tamil >= 70)
            {
                Console.WriteLine(" Tamil subject grade :C");
            }
            else if (Tamil >= 60)
            {
                Console.WriteLine(" Tamil subject grade :D");
            }
            else if (Tamil >= 50)
            {
                Console.WriteLine(" Tamil subject grade :E");
            }
            else
            {
                Console.WriteLine(" Tamil subject grade :F");
            }
            //English grade
            if ((English < 0) || (English > 100))
            {
                Console.WriteLine("Invalid marks.please enter a value between 0 and 100.");
                return;
            }
            if (English >= 90)
            {
                Console.WriteLine("English subject grade :A");
            }
            else if (English >= 80)
            {
                Console.WriteLine("English subject grade :B");
            }
            else if (English >= 70)
            {
                Console.WriteLine("English subject grade :C");
            }
            else if (English >= 60)
            {
                Console.WriteLine("English subject grade :D");
            }
            else if (English >= 50)
            {
                Console.WriteLine("English subject grade :E");
            }
            else
            {
                Console.WriteLine("English subject grade :F");
            }

            //Maths grade
            if ((Maths < 0) || (Maths > 100))
            {
                Console.WriteLine("Invalid marks.please enter a value between 0 and 100.");
                return;
            }
            if (Maths >= 90)
            {
                Console.WriteLine("Maths subject grade :A");
            }
            else if (Maths >= 80)
            {
                Console.WriteLine("Maths subject grade :B");
            }
            else if (Maths >= 70)
            {
                Console.WriteLine("Maths subject grade :C");
            }
            else if (Maths >= 60)
            {
                Console.WriteLine("Maths subject grade :D");
            }
            else if (Maths >= 50)
            {
                Console.WriteLine("Maths subject grade :E");
            }
            else
            {
                Console.WriteLine("Maths subject grade :F");
            }

            //Maths grade
            if ((Science < 0) || (Science > 100))
            {
                Console.WriteLine("Invalid marks.please enter a value between 0 and 100.");
                return;
            }
            if (Science >= 90)
            {
                Console.WriteLine("Science subject grade :A");
            }
            else if (Science >= 80)
            {
                Console.WriteLine("Science subject grade :B");
            }
            else if (Science >= 70)
            {
                Console.WriteLine("Science subject grade :C");
            }
            else if (Science >= 60)
            {
                Console.WriteLine("Science subject grade :D");
            }
            else if (Science >= 50)
            {
                Console.WriteLine("Science subject grade :E");
            }
            else
            {
                Console.WriteLine("Science subject grade :F");
            }

            //SScienece grade
            if ((Socialscience < 0) || (Socialscience > 100))
            {
                Console.WriteLine("Invalid marks.please enter a value between 0 and 100.");
                return;
            }
            if (Socialscience >= 90)
            {
                Console.WriteLine("Socialscince subject grade :A");
            }
            else if (Socialscience >= 80)
            {
                Console.WriteLine("Socialscince subject grade :B");
            }
            else if (Socialscience >= 70)
            {
                Console.WriteLine("Socialscince subject grade :C");
            }

            else if (Socialscience >= 60)
            {
                Console.WriteLine("Socialscince subject grade :D");
            }
            else if (Socialscience >= 50)
            {
                Console.WriteLine("Socialscince subject grade :E");
            }
            else
            {
                Console.WriteLine("F");
            }
            int Totalmark = Tamil + English + Maths + Science + Socialscience;

            double Percentage = (double)Totalmark / 500 * 100;

            Console.WriteLine("---------------------------------");

            String  OverallGrade;
            String Remarks;

            if (Percentage >= 90) 
            {
                Console.WriteLine(OverallGrade = "Overall grade :A");
                Console.WriteLine(Remarks = "Overall Remarks :Excellent");
            }
            else if ((Percentage >=80))
            {
                Console.WriteLine(OverallGrade = "Overall grade :B");
                Console.WriteLine(Remarks = "Overall Remarks :Very Good");
            }
            else if (Percentage >=70)
            {
                Console.WriteLine(OverallGrade = "Overall grade :C");
                Console.WriteLine(Remarks = "Overall Remarks :Good");
            }
            else if (((Percentage >=60)))
            {
                Console.WriteLine(OverallGrade = "Overall grade :D");
                Console.WriteLine(Remarks = "Overall Remarks :Moderate");
            }
            else if ((((Percentage >=50))))
            {
                Console.WriteLine(OverallGrade = "Overall grade : E");
                Console.WriteLine(Remarks = "Overall Remarks : Study Well");
            }

            Console.WriteLine("---------------------------------");

            Console.WriteLine("Student Name : " + Name);
            Console.WriteLine("Tamil Mark :" + Tamil);
            Console.WriteLine("English Mark :" + English);
            Console.WriteLine("Maths Mark :" + Maths);
            Console.WriteLine("Science Mark : " + Science);
            Console.WriteLine("SocialScience Mark :" + Socialscience);
            Console.WriteLine("Student's Totalmark :" + Totalmark);
            Console.WriteLine("Student's Total percentage :" + Percentage);
                     

        }
    }
}