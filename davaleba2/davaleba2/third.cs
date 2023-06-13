using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba2
{
    internal class third
    {
        public void third1()
        {
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++) {

                int result = (int)Math.Pow(i, 3);
                Console.WriteLine(result);

            }
        }
    }
}
