namespace StringDemo
{
    internal class Program
    {
        static void StringPoolExamples()
        {
            string hello = "hello";
            string greeting = "hello";
            string hi = "Hello";            // uppercase
            string hoi = new string("hello");

            Console.WriteLine($"hello ? greeting {object.ReferenceEquals(hello, greeting)}");
            Console.WriteLine($"hello ? hi {object.ReferenceEquals(hello, hi)}");
            Console.WriteLine($"hello ? hoi {object.ReferenceEquals(hello, hoi)}");

            Console.Write("Please enter hello: ");
            string user = Console.ReadLine();
            Console.WriteLine($"hello ? user {object.ReferenceEquals(hello, user)}");
        }

        static void StringIsClass()
        {
            string hello = "Hello World from C#";

            int h = hello.IndexOf('H');
            Console.WriteLine($"h = {h}");

            int csharp = hello.IndexOf("C#");
            Console.WriteLine($"C# = {csharp}");

            int l = hello.Length;

            string lowered = hello.ToLower();
            Console.WriteLine($"lowered = {lowered}");

            Console.WriteLine($"HigherC ? LowerC {object.ReferenceEquals(hello, lowered)}");
        }

        static void CharactersOfString()
        {
            string lol = "Hello Donkey";

            // Printen met spaties
            for (int i = 0; i < lol.Length; i++)
            {
                char x = lol[i];
                Console.Write($"{x} ");
            }

            // Tellen van letters
            int numberOfChars = 0;
            for (int i = 0; i < lol.Length; i++)
            {
                char x = lol[i];

                if (x != ' ')
                {
                    numberOfChars++;
                }
            }
            Console.WriteLine($"\nNumber of characters = {numberOfChars}");
        }

        static void CountUpperCaseLetters()
        {
            string text = "Trump is an ARSE";
            string textLowered = text.ToLower();

            int numberOfUppercase = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != textLowered[i])
                {
                    numberOfUppercase++;
                }

                // Other way
                //if (text[i] >= 'A' && text[i] <= 'Z')
                //{
                //    numberOfUppercase++;
                //}
            }

            Console.WriteLine($"{text} contains {numberOfUppercase} uppercase letters");
        }

        static void ChangeCase()
        {
            string text = "FlipFlop";
            string textAllLower = text.ToLower();

            string changedCase = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == textAllLower[i])
                {
                    changedCase += ("" + text[i]).ToUpper();
                }
                else
                {
                    changedCase += textAllLower[i];
                }
            }

            Console.WriteLine($"{text} becomes {changedCase}");
        }

        static void Main(string[] args)
        {
            StringPoolExamples();
            StringIsClass();
            CharactersOfString();
            CountUpperCaseLetters();
            ChangeCase();
        }
    }
}