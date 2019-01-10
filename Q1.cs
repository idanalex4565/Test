using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
	class Program
	{
		static void Main(string[] args)
		{
			int PrimeNumber1, PrimeNumber2, PrimeNumber3;			
			Console.WriteLine("Please enter 3 numbers between 0 and 1000");
			Console.Write("1st number: ");
			PrimeNumber1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("2nd number: ");
			PrimeNumber2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("3rd number: ");
			PrimeNumber3 = Convert.ToInt32(Console.ReadLine());
			if (CheckBetween0And1000(PrimeNumber1) && CheckBetween0And1000(PrimeNumber2) && CheckBetween0And1000(PrimeNumber3))
			{
				if (PrineCheck(PrimeNumber1) && PrineCheck(PrimeNumber2) && PrineCheck(PrimeNumber3))
				{
					Console.WriteLine($"The sum of the three numbers are = {PrimeNumber1+ PrimeNumber2+ PrimeNumber3}");
				}
				else
				{
					Console.WriteLine("One or more numbers are not prime");
				}
			}
			else
			{
				Console.WriteLine("One or more numbers are not between 0 and 1000");
			}
			Console.ReadLine();

		}

		private static bool CheckBetween0And1000(int PrimeNumber)
		{
			if (PrimeNumber > 0 && PrimeNumber < 1000)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private static bool PrineCheck(int PrimeNumber)
		{
			int m = 2;
			while (PrimeNumber % m != 0)
			{
				m++;
			}

			if (m < PrimeNumber)
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
