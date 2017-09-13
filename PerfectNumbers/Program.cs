using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for(int i = 1; i < 1000000; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }

                }
                if(sum == i)
                {
                    Console.WriteLine(i + " is a Perfect Number");
                }
                sum = 0;
            }
        }
    }
}
