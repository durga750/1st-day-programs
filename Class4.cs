using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattrans
{
    class Class4
    {
        static void Main(string[] args)
        {
            int num = 5;
            for (int i = 1; i < num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + "\t");
                }
                Console.WriteLine();
            }

            for (int i = num; i>=1; i--)
            {
                for (int j =1 ; j <=i; j++)
                {
                    Console.Write($"{j}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
