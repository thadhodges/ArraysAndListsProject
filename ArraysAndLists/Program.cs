﻿using System;
using System.Collections.Generic;
namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            Console.WriteLine("Created an Array with numbers 1-10");
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 1; i <= numbers.Length; i++)
            {
                Console.WriteLine($"number in the array: " + i);
            }
            Console.WriteLine();

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            Console.WriteLine("Created two Lists, one for even numbers and one for odd.");
            Console.WriteLine();
            var evens = new List<int>();
            var odds = new List<int>();


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             * 
             */
            Console.WriteLine("Sorted the array into even and odd lists.");
            Console.WriteLine();
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                if (num % 2 != 0)
                {
                    odds.Add(num);
                }
            }
            Console.WriteLine($"Number of Evens:" + evens.Count);
            Console.WriteLine("______________________________________");

            foreach (var num in evens)
            {
                Console.WriteLine(num);
            }





            Console.WriteLine();
            Console.WriteLine($"Number of odds:" + odds.Count);
            Console.WriteLine("______________________________________");
            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */



            foreach (var num in odds)
            {
                Console.WriteLine(num);
            }


            
        }
    }
}
