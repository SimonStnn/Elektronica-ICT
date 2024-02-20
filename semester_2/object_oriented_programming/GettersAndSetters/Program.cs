namespace GettersAndSetters
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Exercise 1 - Circle
			Console.WriteLine("\nExcercise 1\n-----------");
			Circle circle = new();

			Console.WriteLine($"We made a new circle with radius {circle.GetRadius()} and color {circle.GetColor()}.");

			circle.SetRadius(5);
			circle.SetColor("blue");

			Console.WriteLine($"We changed circle with radius {circle.GetRadius()} and color {circle.GetColor()}.");

			Console.WriteLine($"The area of the circle is {Math.Round(circle.GetArea(), 2)}.");

			// Excercise 2 - Point
			Console.WriteLine("\nExcercise 2\n-----------");
			Point point = new();

			Console.WriteLine($"We made a new point: {point}");

			point.SetXY(5, 0);

			Console.WriteLine($"We moved the point to: {point}");

			Point point2 = new();
			point2.SetXY(6, 7);

			Console.WriteLine($"The distance between point {point} and point {point2} is {point.Distance(point2)}");

			Console.WriteLine($"The distance between point {point} and the origin is {point.Distance()}");
		}
	}
}