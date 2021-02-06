using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfFactorOfNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 12;
            int sum=0;
          
            for(int i=1;i<=12;i++)
            {
                if(num % i==0)
                {
                    sum = sum + i;
                    

                }
            }
            Console.WriteLine(sum);
        }
    }
}
