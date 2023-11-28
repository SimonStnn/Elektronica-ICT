using Microsoft.VisualBasic;
using System.ComponentModel;
using System;
using System.Runtime.CompilerServices;

namespace Arrays
{
	internal class Program
	{
		public static string GetMessageOfTheDay()
		{
			string[] messages =
			{
				"Hello World",
				"Embrace challenges; they forge strength.",
				"Kindness echoes in every action.",
				"Today, be your own sunshine.",
				"Learn from mistakes, grow endlessly.",
				"Smile—it's your best accessory.",
			};
			return messages[new Random().Next(messages.Length)];
		}

		public static double Sum(double[] arr)
		{
			double sum = 0;
			foreach(double num in arr)
				sum += num;
			return sum;
			// Built in function
			return arr.Sum();
		}

		public static double Average(double[] values)
		{
			return Sum(values) / values.Length;
		}

		public static int Min(int[] values)
		{
			if(values.Length == 0) return 0;
			return values.Min();
		}

		public static int IndexOfLowest(int[] values)
		{
			if(values.Length == 0) return -1;
			return Array.IndexOf(values, Min(values));
		}

		public static bool Contains(int[] values, int num)
		{
			return values.Contains(num);
		}

		static void Main(string[] args)
		{
			// 1.Show a 'message of the day' on the console using a methode that returns that message
			// Inside the methode you create a array of strings by using { }, add a minimum of 6 messages.
			Console.WriteLine(GetMessageOfTheDay());

			// 2. Create a array of 10 integers containing the index^2 by using a loop to initialize them
			int[] numbers = new int[10];
			for(int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = i * i;
			}

			// 3. Create a array of 4 doubles by using {}
			double[] floats = { 0.5, 1, 125, 1 };

			// 4. Determine the sum and average of these doubles, write methodes to do so.
			double sum = Sum(floats);
			double average = Average(floats);
			Console.WriteLine($"Sum: {sum}");
			Console.WriteLine($"Average: {average}");

			// 5. Create a array of 6 integers by using {}
			// Show them on the console using a foreach loop
			int[] ints = { 1, 2, 3, 4, 5, 6 };
			foreach(int num in ints)
				Console.Write($"{num} ");
			Console.WriteLine();

			// 6. Determine the minimum of these integers, write a methode to do so
			// Make the methode so that a empty array return zero and test this.
			Console.WriteLine($"Test min function: {Min(ints)}");
			Console.WriteLine($"Test min function: {Min(Array.Empty<int>())}");

			// 7. Create a array of 7 integers by using {} also containing negative values
			int[] nums = { -3, -2, -1, 0, 2, 3, 5, -8 };

			// 8. Determine the position of the lowest number, write a methode to do so
			// Make the methode so that a empty array return -1 and test this
			Console.WriteLine($"Index of lowest in nums: {IndexOfLowest(nums)}");
			Console.WriteLine($"Test for empty array: {IndexOfLowest(new int[0])}");

			// 9. Determine if a array of integers contains a certain value using a methode.
			Console.WriteLine($"Nums contains  1: {Contains(nums, 1)}");
			Console.WriteLine($"Nums contains -1: {Contains(nums, -1)}");
			Console.WriteLine($"Nums contains  5: {Contains(nums, 5)}");

			// 10. Create a 2 dimentional array containing x,y coordinates of 5 points.
			// Write these coordinates to the console
			int[,] coords =
			{
				{ 0, 0 },
				{ 0, 1 },
				{ 1, 2 },
				{ 1, 5 },
			};

			for(int i = 0; i < coords.GetLength(0); i++)
			{
				for(int j = 0; j < coords.GetLength(1); j++)
				{
					Console.Write($"{coords[i, j]} ");
				}
				Console.WriteLine();
			}
		}
	}
}