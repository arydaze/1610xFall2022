// The Expectation is that you write your own code based
// on what you have learned in the class, it can be what you want
// If you are havind trouble thinging of something, write conditionals
// with the topic of PowerUps, what happens if the powerUp is good or bad.
using System;

public class Program
{
	public PowerUps powerUps;
	
    public void Main()
    {
		powerUps = new PowerUps();
		powerUps.addedEffect = PowerUps.Effect.Decrease;
		powerUps.CheckEffect();
    }
}

public class PowerUps
{
	public enum Effect
	{
		Increase,
		Decrease,
		Neutral,
        Super
	}
	
	public Effect addedEffect = Effect.Increase;
	
	public void CheckEffect()
	{
		switch(addedEffect)
		{
			case Effect.Increase:
				Console.WriteLine("Weapon Effect Increased.");
				break;
			case Effect.Decrease:
				Console.WriteLine("Weapon Effect Decreased.");
				break;
			case Effect.Neutral:
				Console.WriteLine("Weapon Effect has remained the same.");
				break;
            case Effect.Super:
                Console.WriteLine("Weapon changed to Super.");
                break;
		}
	}
}