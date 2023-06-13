using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba2
{
    internal class fourth
    {
        public void fourth1()
        {
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 0; i < number; i++)
            {
                if(i % 2 == 1)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
