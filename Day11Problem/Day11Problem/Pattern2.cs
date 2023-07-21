using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problem
{
    internal class Pattern2
    {
        public void pattern(int number)
        {
            int i, j;
            for(i=1;i<=number;i++)
            {
                for(j=1;j<=number;j++)
                {
                    if( i==1 || j==1 || j==number || i==number)
                    {
                        Console.Write("*");
                    }
                    else
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
        }
    }
}
