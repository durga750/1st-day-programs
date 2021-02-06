using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeOrNot
{
    class Perfetnum
    {
        static void Main(string[] args)
        {
            int num = 6;
            int sum = 0, temp;
            temp =num;
            for (int i = 1; i < 6; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                }
            }

            if(sum==temp)
                {
                Console.WriteLine($"{num} is a perfect number");
                 }
            else
            {
                Console.WriteLine($"{num} is noy a perfect number");
            }

        }
    }
}
