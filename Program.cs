using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a n1");
			double n1 = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter a n2");
			double n2 = double.Parse(Console.ReadLine());
			
		    Console.WriteLine("the perfect numbers are:");
			for (double x = n1; x <= n2; x++)
			{
				double sum = 0;

				for (double i = 1; i <= x/2 ; i++)
				{
					if (x % i == 0)
						sum += i;
				}
				if (sum == x)
					Console.WriteLine(x);
			}Console.ReadLine();
		}
	}
}
