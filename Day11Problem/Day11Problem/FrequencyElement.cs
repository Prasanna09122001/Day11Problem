using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problem
{
    internal class FrequencyElement
    {
        public void FrequencyOfElements()
        {
            int a = 0,length;
            Console.WriteLine("Enter the length of array");
            length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            Console.WriteLine("Enter each numbers in the array");
            for (int i = 0; i < length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < length; i++)
            {
                a= 0;
                int number = array[i];
                for (int j = 0; j < length; j++)
                {
                    if (number == array[j])
                    {
                        a++;
                    }
                }
                Console.WriteLine("Frequency of this number " + number + " = " + a);
            }
        }
    }
}
