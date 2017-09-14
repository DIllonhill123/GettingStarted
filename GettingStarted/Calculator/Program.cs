using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculatematron 3000 is ready to compute");
            Console.WriteLine("Enter a Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose your Operation (+,-,*,/):");
            string op = Console.ReadLine();
            Console.WriteLine("Enter your Second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            if(op == "+")
            {
                Console.WriteLine(a + b);
            }
            if (op == "-")
            {
                Console.WriteLine(a - b);
            }

            if (op == "*")
            {
                Console.WriteLine(a * b);
            }

            if (op == "/")
            {
                Console.WriteLine(a / b);
            }
        }
    }
}
