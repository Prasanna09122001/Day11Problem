using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problem
{
    internal class UniqueElements
    {
        public void uniqueelemnts()
        {
            int a = 0;
            Console.WriteLine("Enter the length of array");
            int b = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[b];
            Console.WriteLine("Enter the numbers in array");
            for (int i = 0; i < b; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < b; i++)
            {
                a = 0;
                int num = array[i];
                for (int j = 0; j < b; j++)
                {
                    if (num == array[j])
                    {
                        a++;
                    }
                }
                if (a == 1)
                {
                    Console.WriteLine("Unique Elements is "+num);
                }
            }
        }
    }
}
