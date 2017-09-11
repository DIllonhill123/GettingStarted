using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grade Matchamajigger Initialized");
            Console.WriteLine("Input the Grade:");
            String grade = Console.ReadLine();

            if(grade == "e")
            {
                Console.WriteLine("You have chosen: Excellent");
            }
            if (grade == "v")
            {
                Console.WriteLine("You have chosen: Very Good");
            }
            if (grade == "g")
            {
                Console.WriteLine("You have chosen: Good");
            }
            if (grade == "a")
            {
                Console.WriteLine("You have chosen: Average");
            }
            if (grade == "f")
            {
                Console.WriteLine("You have chosen: Fail");
            }
            else
            {
                Console.WriteLine("Not a real Grade");
            }

        }
    }
}
