using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class second
    {
        public  void Second1()
        {
    
            Console.Write("Enter First Number: ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int second = int.Parse(Console.ReadLine());

            Console.Write("Enter Third Number: ");
            int third = int.Parse(Console.ReadLine());

            bool isTriangle = Triangle(first, second, third);

            if (isTriangle)
            {
                Console.WriteLine("This should be a triangle ");
                Console.WriteLine(Math.Pow(2, 2));
            }
            else
            {
                Console.WriteLine("This Can't be a triangle");
            }

            Console.ReadKey();
        }

        public static bool Triangle(int first, int second, int third)
        {
            if ((first + second > third) && (first + third > second) && (second + third > first))
            {
                return true;
            } else
            {
                return false;
            }

        }
    }
}
