﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int a = 0; a < 3; a++)
            {
                Console.WriteLine("Enter Username:");
                String user = Console.ReadLine();
                Console.WriteLine("Enter Password:");
                String pass = Console.ReadLine();

                if (user == "root" && pass == "Letmein")
                {
                    Console.WriteLine("Welcome!");
                    a = 4;
                }

                if (a == 3)
                {
                    Console.WriteLine("Too many attempts. Try again Later");
                }
            }
        
        }
    }
}
