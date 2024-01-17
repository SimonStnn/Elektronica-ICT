bool isPolindroom(string word)
{
	return word == String.Join("", word.ToCharArray().Reverse());
}

Console.WriteLine(isPolindroom("Mom")); 
Console.WriteLine(isPolindroom("uwu")); 
Console.WriteLine(isPolindroom("joren")); 
Console.WriteLine(isPolindroom("regen"));
Console.WriteLine(isPolindroom("godeliveradareviledog"));