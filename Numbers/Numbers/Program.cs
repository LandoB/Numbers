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
			Console.WriteLine (); // I just need a blank space here

			int upperLimit = int.Parse(Console.ReadLine());

			Console.WriteLine (); // I just need a blank space here
			Console.WriteLine ("Your even numbers are: "); // Listing all even numbers in the list

			List<int> evenIntegers = new List<int>();

			int sum = 0;
			for (var i = 1; i < upperLimit; i++)
			{
				if (i % 2 == 0)
				{
					evenIntegers.Add(i);
					Console.WriteLine(i);
					sum += i;
				}
			}

			Console.WriteLine (); // I just need a blank space here
			Console.WriteLine("Sum of even numbers in array is: ");
			Console.WriteLine (sum);
		}
	}
}
