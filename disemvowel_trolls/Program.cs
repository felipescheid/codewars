using System.Text.RegularExpressions;

public static class Kata
{
	public static string Disemvowel(string str)
	{
		string pattern = "[aeiou]";
		return Regex.Replace(str, pattern, String.Empty, RegexOptions.IgnoreCase);
	}


	static void Main(string[] args)
	{
		foreach (var word in args)
		{
			Console.WriteLine(Disemvowel(word));
		}
	}
}
