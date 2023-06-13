using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba2
{
    internal class fifth
    {
        public void fifth1()
        {
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < number;i++)

            {
                if(list.Count == 0)
                {
                    list.Insert(0,1);
                }
                else if(list.Count % 2 == 0)
                {
                    list.Insert(0,1);
                } else
                {
                    list.Insert(0,0);
                }
                      
                 Console.WriteLine(string.Join(" ", list));

            }
        }
    }
}
