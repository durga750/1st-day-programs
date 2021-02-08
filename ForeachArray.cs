using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsParactice
{
    class ForeachArray
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 23, 54, 2, 7 };
            foreach( int k in a)
            {
                Console.WriteLine(k);
            }
        }
    }
}
