namespace octalToDecimal
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter an octal number: ");
			string octalNumber = $"{Console.ReadLine()}";

			// Convert octal to decimal
			int decimalNumber = Convert.ToInt32(octalNumber, 8);

			Console.WriteLine($"Decimal equivalent: {decimalNumber}");

			decimalNumber = 0;
			for(int i = 0; i < octalNumber.Length; i++)
			{
				byte octal = Convert.ToByte(octalNumber[octalNumber.Length - 1 - i].ToString());
				decimalNumber += Convert.ToInt32(octal * Math.Pow(8, i));
			}
			Console.WriteLine($"Decimal equivalent: {decimalNumber}");
		}
	}
}