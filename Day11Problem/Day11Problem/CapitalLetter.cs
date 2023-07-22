using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problem
{
    public class CapitalLetter
    {
        public void capitalletter()
        {
            string empty = "";
            Console.WriteLine("Enter a Full sentence");
            string s = Console.ReadLine();
            string[] letter = s.Split(new[] { ' ' });
            foreach (string words in letter)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    if (i == 0)
                    {
                        char a = Char.ToUpper(words[i]);
                        empty += a;
                    }
                    else
                    {
                        empty += words[i];
                    }
                }
                empty += " ";
            }
            Console.WriteLine(empty);
        }
    }
}
