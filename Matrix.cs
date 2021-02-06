using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Matrix
    {
        static void Main(string[] args)
        {

            int[,] a = { { 1, 2, 3}, { 4, 5, 6 }, { 7, 8, 9} };
           
            for (int i = 0; i <a.GetLength(0); i++)
            {
                for (int j = 0; j <a. GetLength(1); j++)
                {
                
                    Console.Write(a[i,j]);
                }
                Console.WriteLine();
            }

        }
    }
}
