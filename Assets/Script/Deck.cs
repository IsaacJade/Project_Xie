using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public static List<Card> deck = new List<Card> ();
    private void Awake() {
        deck.Add(new Card(0,"第一张卡",0,"这是第一张卡",0));
        deck.Add(new Card(1,"第二张卡",1,"这是第二张卡",1));
        deck.Add(new Card(2,"第三张卡",2,"这是第三张卡",2));
    }
}
