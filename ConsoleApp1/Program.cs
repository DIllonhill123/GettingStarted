using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNum
{
    class Largest
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Measuring Stick is Ready, Input 3 Numbers");
                Console.WriteLine("Number 1:");
                int numOne = Convert.ToInt32(Console.ReadLine());
            

                Console.WriteLine("Number 2:");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number 3:");
                int numThree = Convert.ToInt32(Console.ReadLine());

            if (numOne > numTwo && numOne > numThree)
                {
                Console.WriteLine("Number One is the Largest");
                }
                if (numTwo > numOne && numTwo > numThree)
                {
                Console.WriteLine("Number Two is the Largest");
                }
                if (numThree > numTwo && numThree > numOne)
                {
                Console.WriteLine("Number Three is the Largest");
                }
            }
        }
    }
