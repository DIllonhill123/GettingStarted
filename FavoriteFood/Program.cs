using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteFood
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorte food?");
            String input = Console.ReadLine();
            if (input == "Burgers")
            {
                Console.WriteLine("10/10 Best Food");
            }
            else
            {
                Console.WriteLine("Wrong Bad Food");
            }
        }
    }
}
