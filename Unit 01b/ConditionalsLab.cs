using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("Sup, Nerds!");
		Addition(17,19);
		Addition(4,42);
		Subtraction(18,7);
		Subtraction(9,11);
		GreaterThan(7,3);
		GreaterThan(5,5);
		GreaterThan(6,4);
		identity("Ary Dazey");
		identity("John F. Kennedy");
	}

	public void Addition(int num, int num2)
	{
		var number = num + num2;
		Console.WriteLine(num + " + " + num2 + " = " + number);
	}
	
	public void Subtraction(int num, int num2)
	{
		var number = num - num2;
		Console.WriteLine(num + " - " + num2 + " = " + number);
	}
	
	public void GreaterThan(int num1, int num2)
	{
		if (num1 > num2) 
		{
			Console.WriteLine(num1 + " is greater than " + num2);
		}
		else if (num1 == num2)
		{
			Console.WriteLine(num1 + " and " + num2 + " are the same");
		}
		else
		{
			Console.WriteLine(num2 + " is greater than " + num1);
		}
	}
	public void identity(string identity)
	{
		if (identity == "Ary Dazey")
		{
			Console.WriteLine(identity + " : Identity Confirmed");
		}
		else
		{
			Console.WriteLine(identity + " : Imposter Detected");
		}
	}
}