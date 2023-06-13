using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class third
    {
        public void Third1() 
        {
            Console.Write("Enter Number :");
            int number = int.Parse(Console.ReadLine());

            double result = Math.Pow(number, 2);
            Console.WriteLine($"The pow of the entered number is : {result}");
            
        }
    }
}
