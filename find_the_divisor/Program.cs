public class Kata
{
	public static int[]? Divisors(int n)
	{
		List<int> divisors = new List<int>();

		for (int i = 2; i <= Math.Sqrt(n); i++) {
			if (n % i == 0) {
				divisors.Add(i);
				if (i != n / i) {
					divisors.Add(n / i);
				}
			}
		}

		if (divisors.Count > 0) {
			return divisors.OrderBy(x => x).ToArray();
		} else {
			if (n != 1) {
				Console.WriteLine($"{n} is prime");
			}
			return null;
		}
	}

	public static void Main(string[] args)
	{
		foreach(var str in args)
		{
			int tryInt;

			if (int.TryParse(str, out tryInt)) {
				int[]? divisors = Divisors(tryInt);

				if (divisors?.Length > 0) {
					Console.WriteLine($"The divisors of {tryInt} are: ");
					foreach (var d in divisors ?? new int[0])
					{
						Console.WriteLine(d);
					}
				}
			}
		}
	}
}
