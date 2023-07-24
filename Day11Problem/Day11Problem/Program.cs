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
                Console.WriteLine("Enter the program to be Executed\n1.Pattern 1\n2.Pattern 2\n3.Sum of digits\n4.Captial Letter\n5.Maximum And Minimum Number");
                Console.WriteLine("6.Reverse Each Element\n7.Frequency Letter\n8.Unique Letter\n9.Sum of Lowest Two\n10.Duplicate Element");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Pattern1 Pat = new Pattern1();
                        Console.WriteLine("Enter the number of times Star to be Printed");
                        int Number = Convert.ToInt32(Console.ReadLine());
                        Pat.Pattern(Number);
                        break;
                    case 2:
                        Pattern2 pattern = new Pattern2();
                        Console.WriteLine("Enter the number of times Star to be Printed");
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
                        CapitalLetter capitalLetter = new CapitalLetter();
                        capitalLetter.capitalletter();
                        break;
                    case 5:
                        MaxMin max = new MaxMin();
                        max.maxmin();
                        break;
                    case 6:
                        ReverseTheWords reverse = new ReverseTheWords();
                        reverse.ReverseEachWords();
                        break;
                    case 7:
                        FrequencyElement Element = new FrequencyElement();
                        Element.FrequencyOfElements();
                        break;
                    case 8:
                        UniqueElements Unique = new UniqueElements();
                        Unique.uniqueelemnts();
                        break;
                    case 9:
                        LowestTwo lowestTwo = new LowestTwo();
                        lowestTwo.Lowesttwo();
                        break;
                    case 10:
                        Duplicate duplicate = new Duplicate();
                        duplicate.DuplicateCount();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}