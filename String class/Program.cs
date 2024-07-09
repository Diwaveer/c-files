using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Write a C# Sharp program to find the length of a string without using a library function.

            /*  string str = "Uniq technologies"; 
              int length = 0;

              foreach (char c in str)
              {
                  length++;
              }

              Console.WriteLine("The length of the string '{0}' is: {1}", str, length);

              //1. Write a C# Sharp program to find the length of a string with using a library function.
              string strg;

              Console.Write("Enter a string: ");
              strg = Console.ReadLine();

              int leng = strg.Length; // Use String.Length property

              Console.WriteLine("The length of the string '{0}' is: {1}", strg, leng); */

            //2.Write a C# Sharp program to separate individual characters from a string.

            /* string str = "Uniq Technologies";
            Console.WriteLine("Individual Characters");

            foreach (char c in str)
            {
                Console.Write(c +" ");
            }
            Console.WriteLine(); */

            //3. Write a program in C# Sharp to print individual characters of the string in reverse order.

            /* string str = "Uniq Technologies";

            Console.WriteLine("Characters in reverse order:");

           
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();*/

            //4. Write a program in C# Sharp to compare two strings without using a string library functions.

            /* bool areEqual = true; // Assume equal initially

             string str1 = "This is a first string";


             string str2 = "This is a first string";

             // Check if strings have the same length
             if (str1.Length != str2.Length)
             {
                 areEqual = false;
             }
             else
             {
                 // Loop through each character and compare
                 for (int i = 0; i < str1.Length; i++)
                 {
                     if (str1[i] != str2[i])
                     {
                         areEqual = false;
                         break; // Exit loop if characters differ
                     }
                 }
             }

             if (areEqual)
             {
                 Console.WriteLine("The strings are equal.");
             }
             else
             {
                 Console.WriteLine("The strings are not equal.");
             }*/

            /*5. Write a program in C# Sharp to count the number of alphabets, digits and
            special characters in a string.*/


            /* int alphabets = 0, digits = 0, specialChars = 0;

            string str = "Welcome 2 Uniq.technologies";

            // Loop through each character in the string
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    alphabets++;
                }
                else if (char.IsDigit(c))
                {
                    digits++;
                }
                else
                {
                    specialChars++;
                }
            }

            Console.WriteLine("Number of alphabets: {0}", alphabets);
            Console.WriteLine("Number of digits: {0}", digits);
            Console.WriteLine("Number of special characters: {0}", specialChars);*/

            //6. Write a C# Sharp program to count the number of vowels or consonants in a string.

            /*string str ="Uniq Technologies";
            int vowels = 0, consonants = 0;

            Console.WriteLine(str.ToLower());

            foreach (char c in str)
            {
                if (c>='a'&& c<='z')
                {
                    if (c=='a'|| c=='e'|| c=='i' || c=='o' || c=='u')
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
            }

            Console.WriteLine("Number of vowels: {0}", vowels);
            Console.WriteLine("Number of consonants: {0}", consonants);*/

            //7. Write a C# Sharp program to find the maximum number of characters in a string.

            /* string input = "Uniq Technologies";

             int maxLength = 0;
             char maxChar = '\0';

             foreach (char c in input)
             {
                 int count = CountOccurrences(input, c);
                 if (count > maxLength)
                 {
                     maxLength = count;
                     maxChar = c;
                 }
             }

             Console.WriteLine($"The maximum number of occurrences is {maxLength} for the character '{maxChar}'.");*/

            //8.Write a C# Sharp program to check whether a given substring is present in the given string.

            /* string str = "This is a test string";
             string substring = "test";
             bool isPresent = false;

             // Loop through each character in the string
             for (int i = 0; i < str.Length; i++)
             {
                 int j = 0; // Index for substring comparison

                 // Check if substring matches starting from current character
                 while (j < substring.Length && i + j < str.Length && str[i + j] == substring[j])
                 {
                     j++;
                 }

                 // If the entire substring matches, set the flag and break
                 if (j == substring.Length)
                 {
                     isPresent = true;
                     break;
                 }
             }

             if (isPresent)
             {
                 Console.WriteLine("The substring is present in the string.");
             }
             else
             {
                 Console.WriteLine("The substring is not present in the string.");
             }*/

            //9.Write a C# Sharp program to check whether a character is an alphabet and not and if so, check for the case.

            /* char ch = 'Z'; 

             if (char.IsLetter(ch))
             {
                 if (char.IsUpper(ch))
                 {
                     Console.WriteLine("The character is uppercase alphabet."); 
                 }
                 else
                 {
                     Console.WriteLine("The character is lowercase alphabet.");
                 }
             }
             else
             {
                 Console.WriteLine("The entered character is not an alphabet.");
             }*/

            /*10.Given two strings s1 and s2, determine if s2 is a rotation of s1. If it is 
            a string rotation, then return the amount of rotation.
            You must output the smaller amount in terms of absolute value. 
            A positive rotation means rotate to the right, while a negative value means rotate to the left.
            If the string is not a rotation, then output the text null.*/

            /*string s1, s2;

            Console.Write("Enter the first string (s1): ");
            s1 = Console.ReadLine();

            Console.Write("Enter the second string (s2): ");
            s2 = Console.ReadLine();

            int rotationAmount = FindRotationAmount(s1, s2);

            if (rotationAmount == -1)
            {
                Console.WriteLine("null");
            }
            else
            {
                Console.WriteLine("The amount of rotation: {0}", rotationAmount);
            }*/


            /*string b = "abc";
            string c = "cab";
             int k = 0;
            while(b!=c)
            {
                A(ref b);
                k++;
            }
            Console.WriteLine("the rotaion value is :" + k);     */




            string input = "rotate tatero";
            string[] inputs = input.Split(' ');
            Console.WriteLine(RotationAmount (inputs[0], inputs[1]));

            input = "abc bca";
            inputs = input.Split(' ');
            Console.WriteLine(RotationAmount(inputs[0], inputs[1]));


        }

        static int RotationAmount(string s1,string s2)
        {
            if (s1.Length !=s2.Length)
            {
               return -1;
            }
            string s1s1 = s1 + s1;
            if(s1s1.Contains(s2))
            {
                int rotation = s1s1.IndexOf(s2) - s1.Length;
                return Math.Min(rotation, s1s1.Length-rotation);
            }
            else
            {
                return -1;
            }
        }
        

        // Function to find the amount of rotation (positive for right, negative for left)
        /* private static int FindRotationAmount(string s1, string s2)
         {
         if (s1.Length != s2.Length)
         {
                return -1; // Not a rotation if lengths differ
         }

        string combinedString = s1 + s1; // Concatenate s1 with itself

        int index = combinedString.IndexOf(s2); // Check if s2 is a substring of the combined string
        if (index >= 0)
        {
             // Calculate the rotation amount based on the index
             int rotation = index;
             if (rotation > s1.Length / 2)
             {
            rotation -= s1.Length; // Handle left rotations efficiently (negative value)
             }
            return rotation;
        }
                 return -1; // Not a rotation

     } */

    /* static int CountOccurrences(string input, char target)
     {
         int count = 0;
        foreach (char c in input)
        {
              if (c == target)
               {
                         count++;
               }
         }
                return count;
     } */


    /* static string A(ref string b)
     {
         char[] ar = b.ToCharArray();
         char temp = ar[0];
         ar[0] = ar[2];
         ar[2] = ar[1];
         ar[1] = temp;

         b= string.Join(" ", ar);
         return b;

     }*/

}


}


   

    

