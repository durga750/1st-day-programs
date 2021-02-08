using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsParactice
{
    class RowAndColSum
    {
        static void Main(string[] args)
        {
           
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 1, 2, 3 } };
            for (int i = 0; i < 3; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i,j]+"\t");
                    sum = sum + a[i,j];
                  
                }
                Console.WriteLine(sum);
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    sum = sum + a[j,i];

                }
                Console.Write(sum+"\t");
            }
            }
    }
}
