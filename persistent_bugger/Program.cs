// https://www.codewars.com/kata/reviews/55ca7d27de10ca001f00001a/groups/65ea2aa8b1dcb50001c3720d

// Teaching myself how to use recursion in C#
// This is not the exact solution I submitted to codewars because I wanted to use top-level statements
// and CLI arguments
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

if (number < 0)
{
	Console.WriteLine("WARNING: does not support negative numbers yet. value will always be 0");
}


 int Persistence(long n, int counter = 0)
{
	if (n < 10)
	{
		return counter;
	}

	long product = 1;

	foreach (char digit in n.ToString())
	{
		// convert char to number - not sure if there's a better way to do it
		product *= (digit - '0');
	}

	return Persistence(product, counter + 1);

}


Console.WriteLine($"Persistence for {number} is {Persistence(number)}");

