using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattrans
{
    class Class3
    {
        static void Main(string[] args)
        {
            int num = 5;
            char ch = 'A';

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(ch + "\t");
                    ch++;
                }
                Console.WriteLine();
            }
        }
    }
}
