using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
	class Program
	{
		static void Main(string[] args)
		{
			int SecondTotel;
			do
			{
				Console.Write("Please enter number of seconds: ");
				SecondTotel = Convert.ToInt32(Console.ReadLine());
			}
			while (ValidNumber(SecondTotel));
			if (SecondTotel / 86400 != 0)
			{
				Console.Write($"{SecondTotel / 86400} Days  ");
				SecondTotel = SecondTotel % 86400;
			}
			if (SecondTotel / 3600 !=0)
			{
				Console.Write($"{SecondTotel / 3600} Hours  ");
				SecondTotel = SecondTotel % 3600;
			}
			if (SecondTotel / 60 != 0)
			{
				Console.Write($"{SecondTotel / 60} Minutes  ");
				SecondTotel = SecondTotel % 60;
			}
			Console.WriteLine($"{SecondTotel} Seconds");
			Console.ReadLine();

		}

		private static bool ValidNumber(int a)
		{			
			if (a <= 0) 
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
