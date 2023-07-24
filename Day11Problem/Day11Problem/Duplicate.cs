using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problem
{
    internal class Duplicate
    {
        public void DuplicateCount()
        {
            int length,a=0,b=0;
            Console.WriteLine("Enter the length of array");
            length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            Console.WriteLine("Enter each numbers in the array");
            for (int i = 0; i < length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] == array[j])
                    {
                        a++;
                        b = array[i];
                    }
                }
            }
            Console.WriteLine("The Duplicate element is "+b +"and count is "+a);
        }
    }
}
