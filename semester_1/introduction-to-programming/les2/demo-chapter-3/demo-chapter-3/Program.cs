using System.Diagnostics.Metrics;

namespace demo_chapter_3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Output to console
			Console.WriteLine("Hello, World!");

			// Declare a variable
			int age = 18;
			double pi = Math.PI;
			string myName = "Simon";

			// Output variable to console
			Console.WriteLine("My name is " + myName);
			Console.WriteLine("I am " + age + " years old");
			Console.WriteLine(pi);

			// Operatoren
			int number = 0;
			number = number + 5;
			number = number - 34;
			number = number * 2;
			number = number / 5;

			double area = 100;
			area = area / 3;

			// Rest bij deling
			int modulo = 5 % 2;
			Console.WriteLine("Rest is " + modulo);

			// A string property
			int length = myName.Length;
			Console.WriteLine("Lengts of my name is " + length);

			string magicNumber = "42";
			int ConvertTheRealMagicNumber = Convert.ToInt32(magicNumber);
			int ParseTheRealMagicNumber = int.Parse(magicNumber);
			Console.WriteLine("The real magic number is " + ConvertTheRealMagicNumber + " and " + ParseTheRealMagicNumber);

			// Decision making
			double waterLevel = 2.4;
			if(waterLevel >= 20)
			{
				Console.WriteLine("Water level is high");
			}
			else if(waterLevel > 10)
			{
				Console.WriteLine("Water level is OK");
			}
			else
			{
				Console.WriteLine("Water level is low");
			}

			// For loop
			for(int i = 0; i < 10; i++)
			{
				Console.WriteLine("i is " + i);
			}
			for(string s = "abcd"; s.Length > 0; s = s.Remove(s.Length - 1, 1))
			{
				Console.WriteLine(s);
			}

			// While loop
			int multiple = 20;
			while(multiple < 100)
			{
				Console.WriteLine("Multiple is: " + multiple);
				multiple *= 3; ;
			}

			// Do while loop
			int sum = 60;
			do
			{
				sum += 20;
				Console.WriteLine("Sum is: " + sum);

			} while(sum < 50);

			sum = 0;
		loopje:
			sum++;
			if(sum > 10) goto eindje;
				
			goto loopje;

		eindje:
			Console.WriteLine(sum);

			// Random generator
			Random generator = new();
			int value = generator.Next();
			Console.WriteLine("Random value is " + value);

			// Random generator with range
			Console.WriteLine("Random value is "+ generator.Next(50,100));
		}
	}
}