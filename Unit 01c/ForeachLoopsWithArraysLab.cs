using System;

public class Program
{
	public void Main() 
	{
		string[] woodTypes = {"Mahogany", "Oak", "Cedar", "Pine", "Burch"};
		foreach (var woodType in woodTypes)
		{
			Console.WriteLine(woodType);
		}
	}
}