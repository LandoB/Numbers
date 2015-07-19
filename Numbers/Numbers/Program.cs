using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayAdding
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter a positive integer: ");
			int upperLimit = int.Parse(Console.ReadLine());

			List<int> evenIntegers = new List<int>();

			for (var i = 1; i < upperLimit; i++)
			{
				if (i % 2 == 0)
				{
					evenIntegers.Add(i);
					Console.WriteLine(i);
				}
			}


		}
	}
}
