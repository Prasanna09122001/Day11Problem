using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problem
{
    internal class ReverseTheWords
    {
        public void ReverseEachWords()
        {
            string a = "";
            Console.WriteLine("Write the Sentence to be reversed");
            string s = Console.ReadLine();
            string[] letter = s.Split(new[] { ' ' });
            foreach (string word in letter)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    a += word[i];
                }
                a += " ";
            }
            Console.WriteLine(a);
        }
    }
}
