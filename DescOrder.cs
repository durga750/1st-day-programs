using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class DescOrder
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 3, 7, 8, 1, 4, 6 };
            int temp;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }

                }
                Console.Write(a[i] + "\t");

            }
        }
    }
}
