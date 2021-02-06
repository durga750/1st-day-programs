using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
	class Program2
	{
		static void Main(string[] args)
		{
			int start = 1;
			int sum = 0;
			while (start <= 5)
			{
				sum = sum + start;
				start++;
			}
			Console.WriteLine(sum);
		}
	}
}
