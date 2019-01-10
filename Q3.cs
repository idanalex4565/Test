using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Please enter size of Triangle: ");
			int size = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i <= size; i++)
			{				
				for (int j = 1; j <= size; j++)
				{
					if (i >= j) 
					{
						Console.Write(j);
					}
					else
					{
						Console.Write("*");
					}
				}
				Console.WriteLine();
			}
			Console.ReadLine();
		}
	}
}
