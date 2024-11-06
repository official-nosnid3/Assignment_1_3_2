using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_1_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 1.3.2
             * Write a console application in C# to explore different ways in which array is declared and 
             * initialized and explore different properties and methods of Array class. 
             
             provide the length and sort each array */

            string[] fnames = new string[3] { "Will", "Harry", "Samantha" };
            int[] ages = new int[3] { 31, 28, 25 };
            bool[] marriageStatuses = new bool[3] { false, true, true };

            Console.WriteLine("The length of the first array: " + fnames.Length);
            Console.WriteLine("The length of the second array: " + ages.Length);
            Console.WriteLine("The length of the third array: " + marriageStatuses.Length);

            Console.WriteLine();
            for (int i = 0; i < fnames.Length; i++)
            {
                Console.WriteLine($"{fnames[i]} is {ages[i]} years old, and he/she being married is a { Convert.ToString( marriageStatuses[i] ).ToLower() } statement.");
            }

            Array.Sort(fnames);
            Array.Sort(ages);
            Array.Sort(marriageStatuses);

            Console.WriteLine();
            for (int i = 0; i < fnames.Length; i++)
            {
                Console.WriteLine($"{fnames[i]} is {ages[i]} years old, and he/she being married is a {Convert.ToString(marriageStatuses[i]).ToLower()} statement.");
            }
        }
    }
}
