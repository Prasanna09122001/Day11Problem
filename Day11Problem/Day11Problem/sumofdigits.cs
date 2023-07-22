using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problem
{
    internal class sumofdigits
    {
        public void sum(int number)
        {
            int a, b=0;
            while(number > 0)
            {
                a = number % 10;
                b += a;
                number = number / 10;
            }
            Console.WriteLine("Sum of the digits is "+b);
        }
    }
}
