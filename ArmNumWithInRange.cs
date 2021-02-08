using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsParactice
{
    class ArmNumWithInRange
    {
        static void Main(string[] args)
        {
            for (int j = 1; j <= 10000; j++)
            {
                int num = j;
                int count = 0;
                int sum = 0;
                int copy = num;
                while (num > 0)
                {
                    int digit = num % 10;
                    count++;
                    num /= 10;
                }
                num = copy;
                while (num > 0)
                { 
                   int power = 1;
                    int digit = num % 10;
                    for (int i = 1; i <= count; i++)
                    {
                        power = power * digit;
                    }
                    sum = sum + power;
                    num /= 10;
                }
                if (sum == j)
                {
                    Console.WriteLine(j);
                }

            }
        }
    }
}
