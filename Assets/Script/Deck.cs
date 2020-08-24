using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Deck : MonoBehaviour
{
    public List<Card> deck = new List<Card> ();
    public Text remain;
    private int numCardRemain;
    private void Awake() 
    {

        deck.Add(Resources.Load<Card>("Cards/test1"));
        deck.Add(Resources.Load<Card>("Cards/test2"));
        deck.Add(Resources.Load<Card>("Cards/test3"));
        deck.Add(Resources.Load<Card>("Cards/test4"));
        deck.Add(Resources.Load<Card>("Cards/test5"));

        shuffle();

        numCardRemain = deck.Count;
    }
    private void Update() {
        remain.text = numCardRemain.ToString();
    }
    public void shuffle()
    {
        for (int i = 0; i < deck.Count; i++) {
         Card temp = deck[i];
         int randomIndex = Random.Range(i, deck.Count);
         deck[i] = deck[randomIndex];
         deck[randomIndex] = temp;
     }
    }
    public Card drawCard()
    {
        //install afterward
        return new Card();
    }
    public int getRemain()
    {
        return numCardRemain;
    }
}
