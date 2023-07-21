using System;

namespace Day11Problem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome To Day 11 Problem Statement");
            bool flag = true;
            while (flag)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Pattern1 Pat = new Pattern1();
                        int Number = Convert.ToInt32(Console.ReadLine());
                        Pat.Pattern(Number);
                        break;
                }
            }
        }
    }
}