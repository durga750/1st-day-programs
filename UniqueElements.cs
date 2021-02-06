using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class UniqueElements
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 5,3}; 
            for (int i = 0; i < a.Length; i++)
            { 
                int count = 0;
                for (int j =0; j < a.Length; j++)
                {
                  
                         if (a[i] == a[j])
                         {
                           count++;
                         }
                }

                if (count == 1)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }
}

