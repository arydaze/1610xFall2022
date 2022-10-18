using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
	public new string name;
	
	public Sprite artwork;
	public Sprite rarity;
	public Sprite layout;
	public Sprite powerLvl;

	public int spaceCount;
}
