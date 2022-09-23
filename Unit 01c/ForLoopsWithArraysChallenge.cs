using System;

public class Program
{
    public void Main()
    {
		string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        for (int i = 0; i < 7; i++)
		{
			Console.WriteLine("Today is " + days[i] + ".");
		}
		
		Console.WriteLine("These are the days of the week.");
    }
}