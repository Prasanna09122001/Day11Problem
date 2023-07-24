using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problem
{
    internal class LowestTwo
    {
        public void Lowesttwo()
        {
            Console.WriteLine("Enter the Length of the Array");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            Console.WriteLine("Enter each numbers in the array");
            for (int i = 0; i < length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min1 = array[0];
            int min2 = array[1];
            if (min2 < min1)
            {
                int temp = min1;
                min1 = min2;
                min2 = temp;
            }
            for (int i = 2; i < length; i++)
            {
                if (array[i] < min1)
                {
                    min2 = min1;
                    min1 = array[i];
                }
                else if (array[i] < min2)
                {
                    min2 = array[i];
                }
            }
            Console.WriteLine("Sum of the lowest Two Elements"+(min1+min2));
        }
    } 
}
