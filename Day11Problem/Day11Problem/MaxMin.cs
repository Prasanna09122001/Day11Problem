using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problem
{
    public class MaxMin
    {
        public void maxmin()
        {
            int a,b;
            Console.WriteLine("Enter the full length of array");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            Console.WriteLine("Enter the numbers in array");
            for (int i = 0; i < length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            a = array[0];
            b = array[0];
            for (int i = 0; i < length; i++)
            {
                if (array[i] > a)
                {
                    a = array[i];
                }
                if (array[i] < b)
                {
                    b = array[i];
                }
            }
            Console.WriteLine("Maximum element in the array is " + a);
            Console.WriteLine("Minimun element in the array is " + b);
        }
    }
}
