using GettersAndSetters;

namespace Properties
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			Point begin = new();
			begin.X = 10;
			begin.Y = 20;
			Point end = new();
			end.X = 30;
			end.Y = 40;

			Line line = new();
			line.Begin = begin;
			line.End = end;

			Console.WriteLine(line);

			int[] beginXY = line.GetBeginXY();
			Console.WriteLine($"beginX = {beginXY[0]}");
			Console.WriteLine($"beginY = {beginXY[1]}");

			Console.WriteLine($"Length: {line.GetLength():F2}");

			Circle circle = new();
			circle.Radius = 5.3;
			circle.Origin = begin;

			Console.WriteLine(circle);
			Console.WriteLine($"Area of the circle {circle} is: {circle.Area()}");
		}
	}
}