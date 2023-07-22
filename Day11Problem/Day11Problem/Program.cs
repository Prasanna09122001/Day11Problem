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
                Console.WriteLine("Enter the program to be Executed\n1.Pattern 1\n2.Pattern 2\n3.");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Pattern1 Pat = new Pattern1();
                        Console.WriteLine("ENter the number of times Star to be Printed");
                        int Number = Convert.ToInt32(Console.ReadLine());
                        Pat.Pattern(Number);
                        break;
                    case 2:
                        Pattern2 pattern = new Pattern2();
                        Console.WriteLine("ENter the number of times Star to be Printed");
                        int Number1 = Convert.ToInt32(Console.ReadLine());
                        pattern.pattern(Number1);
                        break;
                    case 3:
                        sumofdigits Sumofdigit = new sumofdigits();
                        Console.WriteLine("Enter the number ");
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        Sumofdigit.sum(number2);
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}