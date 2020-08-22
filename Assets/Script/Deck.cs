using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public static List<Card> deck = new List<Card> ();
    private void Awake() 
    {
        deck.Add(new Card("testing","this is a testing card",1,5,6));
        deck.Add(new Card("测试","测试一下",2,7,9));
    }
}
