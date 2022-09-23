using System;

public class Program 
{
    public void Main()
    {
        int i = 0;
        while (i<5)
        {
            Console.WriteLine(i + " is less than 5.");
            i++;
        }
		
		while (i==5)
		{
			Console.WriteLine(i + " is equal to 5.");
			break;
		}
    }
}