using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int id;
    public string cardName;
    public int cost;
    public string cardDescription;
    public int power;//不是很确定
    public Card(int Id, string Name, int Cost, string Description, int Power)
    {
        this.id = Id;
        this.cardName = Name;
        this.cost = Cost;
        this.cardDescription = Description;
        this.power = Power;
    }
}
