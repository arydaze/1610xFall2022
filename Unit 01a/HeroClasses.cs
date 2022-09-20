//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	public Hero heroThree;
	
	public void Main()
	{
		Console.WriteLine("Character Select:");
		heroOne = new Hero();
		heroTwo = new Hero();
		heroThree = new Hero();

		heroOne.health = 2;
		heroOne.powerLevel = 5;
		heroOne.weaponClass = "Spears, Swords, Axes, Daggers";
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
		heroTwo.weaponClass = "Harps, Daggers, Bows";
		
		heroThree.health = 1;
		heroThree.powerLevel = 7;
		heroThree.weaponClass = "Whips, Rods, Daggers, Bows";
		
		Console.WriteLine("Drakon Knight Health");
		Console.WriteLine(heroOne.health);
		Console.WriteLine("Drakon Knight Power LVL");
		Console.WriteLine(heroOne.powerLevel);
		Console.WriteLine("Drakon Knight Weapon Classes");
		Console.WriteLine(heroOne.weaponClass);
		
		Console.WriteLine("Bard Health");
		Console.WriteLine(heroTwo.health);
		Console.WriteLine("Bard Power LVL");
		Console.WriteLine(heroTwo.powerLevel);
		Console.WriteLine("Bard Weapon Classes");
		Console.WriteLine(heroTwo.weaponClass);
		
		Console.WriteLine("Summoner Health");
		Console.WriteLine(heroThree.health);
		Console.WriteLine("Summoner Power LVL");
		Console.WriteLine(heroThree.powerLevel);
		Console.WriteLine("Summoner Weapon Classes");
		Console.WriteLine(heroThree.weaponClass);
	}
}

public class Hero 
{
	public int health;
	public int powerLevel;
	public string weaponClass;
}