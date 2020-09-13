using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject {

	public new string name;
	public string description;

	public Sprite artwork;

	public int manaCost;
	public int attack;
	public int health;

	public bool cardBack;
	public Card(string Name, string Description, int ManaCost, int Attack,int Health)
	{
		name = Name;
		description = Description;
		manaCost = ManaCost;
		attack = Attack;
		health = Health;
		cardBack = false;
	}
	public Card()
	{
		//default constructor
	}
	public void Print ()
	{
		Debug.Log(name + ": " + description + " The card costs: " + manaCost);
		Debug.Log(name + ": " + description + " The card costs: " + manaCost);
	}


}
