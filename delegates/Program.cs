using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    // Define a delegate
    delegate void MyDelegate(int x, ref int y, out int z);

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of the delegate for each method type
            MyDelegate delByValue = new MyDelegate(MethodByValue);
            MyDelegate delByRef = new MyDelegate(MethodByReference);
            MyDelegate delOut = new MyDelegate(MethodByOut);

            int a = 10;
            int b = 20;
            int c;

            // Call the delegate for call by value method
            delByValue(a, ref b, out c);
            Console.WriteLine($"After call by value method: a = {a}, b = {b}, c = {c}");

            // Reset values for next call
            b = 20;
            c = 0;

            // Call the delegate for call by reference method
            delByRef(a, ref b, out c);
            Console.WriteLine($"After call by reference method: a = {a}, b = {b}, c = {c}");

            // Reset values for next call
            b = 20;
            c = 0;

            // Call the delegate for out parameter method
            delOut(a, ref b, out c);
            Console.WriteLine($"After out parameter method: a = {a}, b = {b}, c = {c}");
        }

        // Method demonstrating call by value
        static void MethodByValue(int x, ref int y, out int z)
        {
            // Modify x by value
            x += 5;

            // Modify y by reference
            y += 10;

            // Assign a value to z using out parameter
            z = x + y;
        }

        // Method demonstrating call by reference
        static void MethodByReference(int x, ref int y, out int z)
        {
            // Modify x by reference
            x -= 5;

            // Modify y by reference
            y -= 10;

            // Assign a value to z using out parameter
            z = x - y;
        }

        // Method demonstrating out parameter
        static void MethodByOut(int x, ref int y, out int z)
        {
            // Assign a value to z using out parameter
            z = x * y;
        }


    }
}