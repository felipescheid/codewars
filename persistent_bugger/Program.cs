// Can we use recursion in C#? Let's find out
int number = 237;
Console.WriteLine($"Persistence for {number} is {PersistentBugger.Persistence(number)}");

class PersistentBugger
{
	private static int counter = 0;

	public static int Persistence(long n)
	{
		/*
		 * Now here is what we want to do:
		 * 1) breakdown the number into its own digits
		 * 2) multiply all digits and check result
		 * 3) create a counter starting at 1
		 * 4) if result has single digit, return counter
		 * 5) else, increment counter and call function again with result
		 */
		counter++;

		string text = n.ToString();
		long product = 1;

		foreach (char digit in text)
		{
			// convert char to digit - not sure if there's a better way to do it
			int num = digit - '0';
			product *= num;
		}

		if (product > 10)
		{
			Console.WriteLine($"Product for {n} is {product}. Re-calling function with {product}");
			return Persistence(product);
		} 

		return counter;
	}
}
