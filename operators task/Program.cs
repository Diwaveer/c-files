using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace operators
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                int a;
                int b;
                int c;
                int x;
                int y;
                int z;

                Console.Write("Enter the value for a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for b:");
                b = Convert.ToInt32(Console.ReadLine());
                int result1 = (a + b) * (a + b);
                Console.WriteLine($"({a} + {b})^2 = {result1}");


                Console.Write("Enter the value for a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for b:");
                b = Convert.ToInt32(Console.ReadLine());
                int result2 = (a + b) * (a - b);
                Console.WriteLine($"{a}^2-{b}^2 ={result2}");

                Console.Write("Enter the value for a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for b:");
                b = Convert.ToInt32(Console.ReadLine());
                int result3 = (a * a) + (b * b);
                Console.WriteLine($"{a}^2+{b}^2 = {result3}");

                Console.Write("Enter the value for a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for b:");
                b = Convert.ToInt32(Console.ReadLine());
                int result4 = (a - b) * (a - b);
                Console.WriteLine($"({a} - {b})^2 = {result4}");

                Console.Write("Enter the value for a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for b:");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for c:");
                c = Convert.ToInt32(Console.ReadLine());
                int result5 = (a + b + c) * (a + b + c);
                Console.WriteLine($"{a + b + c}^2 = {result5}");

                Console.Write("Enter the value for a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for b:");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for c:");
                c = Convert.ToInt32(Console.ReadLine());
                int result6 = (a - b - c) * (a - b - c);
                Console.WriteLine($"{a - b - c}^2 = {result6}");

                Console.Write("Enter the value for a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for b:");
                b = Convert.ToInt32(Console.ReadLine());
                int result7 = (a + b) * (a + b) * (a + b);
                Console.WriteLine($"{a + b}^3 = {result7}");

                Console.Write("Enter the value for a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for b:");
                b = Convert.ToInt32(Console.ReadLine());
                int result8 = (a - b) * (a - b) * (a - b);
                Console.WriteLine($"{a - b}^3 = {result8}");

                Console.Write("Enter the value for a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for b:");
                b = Convert.ToInt32(Console.ReadLine());
                int result9 = (a * a * a) + (b * b * b);
                Console.WriteLine($"{a}^3+{b}^3 = {result9}");

                Console.Write("Enter the value for a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for b:");
                b = Convert.ToInt32(Console.ReadLine());
                int result10 = (a * a * a) - (b * b * b);
                Console.WriteLine($"{a}^3-{b}^3 = {result10}");

                Console.Write("Enter the value for a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for b:");
                b = Convert.ToInt32(Console.ReadLine());
                int result11 = (a + b) * (a + b) * (a + b) * (a + b);
                Console.WriteLine($"{a + b}^4 = {result11}");

                Console.Write("Enter the value for a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for b:");
                b = Convert.ToInt32(Console.ReadLine());
                int result12 = (a - b) * (a - b) * (a - b) * (a - b);
                Console.WriteLine($"{a - b}^4 = {result12}");

                Console.Write("Enter the value for a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for b:");
                b = Convert.ToInt32(Console.ReadLine());
                int result13 = (a * a * a * a) - (b * b * b * b);
                Console.WriteLine($"{a}^4-{b}^4 = {result13}");

                Console.Write("Enter the value for a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for b:");
                b = Convert.ToInt32(Console.ReadLine());
                int result14 = (a * a * a * a * a) - (b * b * b * b * b);
                Console.WriteLine($"{a}^5-{b}^5 = {result14}");

                Console.Write("Enter the value for x:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for y:");
                y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for :z");
                z = Convert.ToInt32(Console.ReadLine());
                int result15 = (x + y - z) * (x + y - z);
                Console.WriteLine($"{x + y - z}^2 = {result15}");

                Console.Write("Enter the value for x:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for y:");
                y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for :z");
                z = Convert.ToInt32(Console.ReadLine());
                int result16 = (x - y + z) * (x - y + z);
                Console.WriteLine($"{x - y + z}^2 = {result16}");

                Console.Write("Enter the value for x:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for y:");
                y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for :z");
                z = Convert.ToInt32(Console.ReadLine());
                int result17 = (x * x * x) ^ 3 + (y * y * y) ^ 3 + (z * z * z) ^ 3 + (3 * x * y * z);
                Console.WriteLine($"{x}^3+{y}^3+{z}^3+3xyz = {result17}");

                Console.Write("Enter the value for x:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for b:");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for c:");
                c = Convert.ToInt32(Console.ReadLine());
                int result18 = (x + a) * (x + b) * (x + c);
                Console.WriteLine($"(x+a)*(x+b)*(x+c) = {result18}");











            }


        }
    }

}
    }
}
