using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 0; i < 10; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            var second = new second();
            second.seond1();

            var third = new third();
            third.third1();

            var fourth = new fourth(); 
            fourth.fourth1();

            var fifth = new fifth();   
            fifth.fifth1();


        }
    }
}
