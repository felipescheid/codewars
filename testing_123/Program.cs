/*
 * This is my first start using Linq! I think that using Select in this context is very similar
 * to the map operation in Javascript.
 */
public class Program
{
	public static List<string> Number(List<string> lines)
	{
		return lines.Select((line, index) => $"{index + 1}: {line}").ToList();
	}

	static int Main(string[] args)
	{
		List<string> lines = args.ToList();

		foreach(var word in Number(lines))
		{
			Console.WriteLine(word);
		}
		return 1;
	}
}
