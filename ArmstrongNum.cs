using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsParactice
{
    class ArmstrongNum
    {
        static void Main(string[] args)
        {
            int num = 153;
            int count = 0;
            int sum = 0;
            int temp;
            temp = num;

            while (num > 0)
            {
                int digit = num % 10;
                count++;
                num = num / 10;

            }
            num = temp;
            while (num > 0)
            {
                int digit = num % 10;
                int pval = 1;
                for (int i = 1; i <= count; i++)
                {
                    pval = pval * digit;
                }
                sum = sum + pval;
                num = num / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("{0} is armstrong num", temp);
            }
            else
            {
                Console.WriteLine("{0} is not armstrong num", temp);
            }

        }
    }
}
