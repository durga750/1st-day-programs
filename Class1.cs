using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeOrNot
{
    class StrongNum
    {
        static void Main(string[] args)
        {



            int num = 145;
            int temp;
            int sum = 0;
            temp = num;
            while (num != 0)
            {
                 int fact = 1;
                 int digit = num % 10;

                for(int i = 1; i <= digit; i++) 
                {
                    fact = fact * i;
                   
                }

                sum = sum + fact;
                num = num / 10;
            }
            Console.WriteLine(sum);
            if (temp == sum)
            {
                Console.WriteLine($"{temp} is a strong number");
            }
            else
            {
                Console.WriteLine($"{temp} is not a strong number");
            }
        }
    }
}
