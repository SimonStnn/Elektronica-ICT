using System.Reflection;

namespace KlassikaalLes7
{
	internal class Program
	{
		public static int AskNumber(string message)
		{
			Console.Write(message);
			return Convert.ToInt32(Console.ReadLine());
		}
		static void Main(string[] args)
		{
			//// Get 3 numbers from the user
			//int number1 = AskNumber("Geef getal 1 op:");
			//int number2 = AskNumber("Geef getal 2 op:");
			//int number3 = AskNumber("Geef getal 3 op:");

			//// Sort numbers


			//// Print numbers
			//Console.WriteLine($"De gesorteerde nummers zijn: {number1} {number2} {number3}");

			// Ask age
			int age = AskNumber("What is your age: ");

			// Get day of the week
			string day = DateTime.Today.DayOfWeek.ToString();
			float price = 13.3f;
			if(day == "Saturday" || day == "Sunday")
				price = 15.1f;

			if(age < 5)
				price = 0;
			else if(age < 13)
				price /= 2;
			else if(age >= 55)
				price = price * 80 / 100;

			Console.WriteLine($"The price is {price} euro.");
		}
	}
}