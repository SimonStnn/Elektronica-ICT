namespace Loops
{
	internal class Program
	{
		public static void CountDown(int from)
		{
			for (; from > 0 ;from--)
			{
				Console.WriteLine(from);
			}
		}

		static void Main(string[] args)
		{
			for(int i = 0; i < 4; i+=2)
				Console.WriteLine($"{i,2}. Hello, World!");

			CountDown(5);
		}
	}
}