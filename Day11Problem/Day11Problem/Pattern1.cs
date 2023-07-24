using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problem
{
    internal class Pattern1
    {
        public void Pattern(int number)
        {
            int i, j;
            for(i=number; i>0;i--)
            {
                for(j=i; j>0;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
          
        }
    }
}
