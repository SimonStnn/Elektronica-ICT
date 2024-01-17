bool isPolindroom(string word)
{
	return word == String.Join("", word.ToCharArray().Reverse());
}

bool isPolindroom2(string word)
{
	string reverse = "";
	for(int i = word.Length - 1; i >= 0; i--)
	{
		reverse += word[i];
	}
	return word == reverse;
}

Console.WriteLine("1:");
Console.WriteLine(isPolindroom("Mom"));
Console.WriteLine(isPolindroom("uwu"));
Console.WriteLine(isPolindroom("joren"));
Console.WriteLine(isPolindroom("regen"));
Console.WriteLine(isPolindroom("godeliveradareviledog"));

Console.WriteLine("2:");
Console.WriteLine(isPolindroom2("Mom"));
Console.WriteLine(isPolindroom2("uwu"));
Console.WriteLine(isPolindroom2("joren"));
Console.WriteLine(isPolindroom2("regen"));
Console.WriteLine(isPolindroom2("godeliveradareviledog"));