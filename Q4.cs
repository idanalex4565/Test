using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
	class Program
	{
		static void Main(string[] args)
		{
			int stars;
			do
			{
				Console.Write("Please enter the hight of the piramid: ");
				stars = Convert.ToInt32(Console.ReadLine());
			}
			while (Between1And15Check(stars));			
			for (int i = 1; i <= stars; i++)
			{
				for (int j = stars; j > i; j--)
				{
					Console.Write(" ");
				}
				for (int j = 1; j < i * 2; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			Console.ReadLine();
		}

		private static bool Between1And15Check(int stars)
		{
			if (stars > 0 && stars < 16)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}
