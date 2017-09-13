using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            for(int i = 1; i < 1000; i++)
            {
                isPrime = true;
                for(int j = 2; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        isPrime = false;
                       
                    }

                }
                if(isPrime == true)
                {
                    Console.WriteLine(i + " is Prime");
                }
            }
        }
    }
}
