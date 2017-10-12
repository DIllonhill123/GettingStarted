using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Arr = new String[100];
            for(int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = i + ". ";
                if(i % 3 == 0)
                {
                    Arr[i] += "Fizz";
                }
                if(i % 5 == 0)
                {
                    Arr[i] += "Buzz";
                }
            }
            for(int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine(Arr[i]);
            }
            
        }
    }
}
