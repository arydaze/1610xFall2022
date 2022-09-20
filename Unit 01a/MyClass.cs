//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

//Based on the HelloWorld File, turn this into a class.

//Write a console program with a program class, and Main Function
//Add another class with any name, add variables 
//Using the new keyword create several objects
//Console writeline the Objects variables

using System;
					
public class Program
{
	public Enemy enemyOne;
	public Enemy enemyTwo;
	public Enemy enemyThree;
	
	public void Main()
	{
		enemyOne = new Enemy();
		enemyTwo = new Enemy();
		enemyThree = new Enemy();
		
		enemyOne.damage = 56;
		enemyOne.size = "Small";
		enemyOne.defense = "3";
		
		enemyTwo.damage = 86;
		enemyTwo.size = "Large";
		enemyTwo.defense = "4";
		
		enemyThree.damage = 160;
		enemyThree.size = "Giant";
		enemyThree.defense = "?";
		
		Console.WriteLine("Blood Bat Damage");
		Console.WriteLine(enemyOne.damage);
		Console.WriteLine("Blood Bat Size");
		Console.WriteLine(enemyOne.size);
		Console.WriteLine("Blood Bat Defense LVL");
		Console.WriteLine(enemyOne.defense);
		Console.WriteLine("");
		
		Console.WriteLine("Mad Ogre Damage");
		Console.WriteLine(enemyTwo.damage);
		Console.WriteLine("Mad Ogre Size");
		Console.WriteLine(enemyTwo.size);
		Console.WriteLine("Mad Ogre Defense LVL");
		Console.WriteLine(enemyTwo.defense);
		Console.WriteLine("");
		
		Console.WriteLine("Fiend Dragon Damage");
		Console.WriteLine(enemyThree.damage);
		Console.WriteLine("Fiend Dragon Size");
		Console.WriteLine(enemyThree.size);
		Console.WriteLine("Fiend Dragon Defense LVL");
		Console.WriteLine(enemyThree.defense);
	}
}

public class Enemy
{
	public int damage;
	public string size;
	public string defense;
}