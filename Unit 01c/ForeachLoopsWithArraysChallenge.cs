using System;

public class Program
{
	public void Main()
	{
		string[] sports = {"basketball", "baseball", "football", "rugby", "hockey"};
		foreach (var sport in sports)
		{
			Console.WriteLine("This sport is " + sport + ".");
		}
		
		int[] counts = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0};
		foreach (var count in counts)
		{
			if (count > 0)
			{
				Console.WriteLine(count);
			}
			else
			{
				Console.WriteLine("Time's Up!");
			}
		}
	}
}