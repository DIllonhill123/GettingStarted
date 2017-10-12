using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] Arr = new int[50];
            Random rnd = new Random();
            int[] Arr2 = new int[50];
            bool dupe = false;

            for(int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = rnd.Next(1, 50);
                
            }
            Array.Sort(Arr);
            for(int i = 0; i < Arr.Length; i++)
            {
                for(int j = i+1; j < Arr.Length; j++)
                {
                    if(Arr[i] == Arr[j])
                    {
                        dupe = true;
                        
                    }
                    break;

                }
                if(dupe == false)
                {
                    Arr2[i] = Arr[i];
                }
                dupe = false;
            }
            for(int i = 0; i < Arr2.Length; i++)
            {
                Console.WriteLine(Arr2[i]);
            }

        }
    }
}
