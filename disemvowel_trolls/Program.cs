public static class Kata
{
	public static string Disemvowel(string str)
	{
		return str;
	}


	static void Main(string[] args)
	{
		foreach (var word in args)
		{
			Console.WriteLine(Disemvowel(word));
		}
	}
}
