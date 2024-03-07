// Teaching myself how to use recursion in C#
if (args.Length != 1)
{
	Console.WriteLine("Usage: dotnet run <number>");
	return;
}

if (!long.TryParse(args[0], out long number))
{
	Console.WriteLine("Invalid number format");
	return;
}

Console.WriteLine($"Persistence for number {args[0]} is {PersistentBugger.Persistence(number)}");


class PersistentBugger
{
	public static int Persistence(long n, int counter = 0)
	{
		if (n < 10)
		{
			return counter;
		}

		string text = n.ToString();
		long product = 1;

		foreach (char digit in text)
		{
			// convert char to digit - not sure if there's a better way to do it
			int num = digit - '0';
			product *= num;
		}

		return Persistence(product, counter + 1);

	}
}
