using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class MaxEleInArray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 4, 3, 7, 6, 5 };
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                    if ( a[i]>max)
                    {
                    max = a[i];
                    }
                
                }
            Console.WriteLine(max);
            }
        }
    }

