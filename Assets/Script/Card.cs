using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public abstract class Card : MonoBehaviour {

	public int CardNo; //unique card no.
	public string cardName;
	public string description;
	public Sprite artwork;
	public int Cost;
	


	public Card(string Name, string Description, int ManaCost, Sprite art)
	{
		cardName = Name;
		description = Description;
		Cost = ManaCost;
		artwork = art;
	}
	public Card()
	{
		//default constructor
	}
	public void Print ()
	{
		Debug.Log(name + ": " + description + " The card costs: " + Cost);
	}

	public virtual void execute()
    {
		this.Print();
    }

}
