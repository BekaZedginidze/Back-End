﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba2
{
    internal class second
    {
        public void seond1()
        {
            int sum = 0;
             Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());
             for(int i = 0; i < number; i++)
             {  
                sum += i;

             }
            Console.WriteLine(sum);
        }

    }
}
