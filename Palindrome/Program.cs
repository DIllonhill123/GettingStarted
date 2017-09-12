using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindome Checker");
            while (1 > 0)
            {
                Console.WriteLine("Input a word:");
                string word = Console.ReadLine();

                Char[] wordArr = word.ToCharArray();
                Array.Reverse(wordArr);
                string drow = new string(wordArr);

                if (word == drow)
                {
                    Console.WriteLine(word + " is a palindrome");
                }
                else
                {
                    Console.WriteLine(word + " is not a palindrome");
                }
            }
        }
    }
}
