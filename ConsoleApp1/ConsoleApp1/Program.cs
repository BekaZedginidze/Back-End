using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            string name = Console.ReadLine();

            
            int result = Int32.Parse(name);

            if (result % 2 == 0)
            {
                Console.WriteLine($"Entered numbre {result} is even");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Entered numbre {result} is odd");
                Console.ReadKey();


            }

            var second = new second();
            second.Second1();

            var third = new third();
            third.Third1();

        }

    }
}