using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Deck : MonoBehaviour
{
    public List<Card> deck = new List<Card> ();
    private List<Card> graveyard = new List<Card>();
    public Text remain;
    private int numCardRemain;
    public GameObject handZone;
    private void Awake() 
    {

        deck.Add(Resources.Load<Card>("Cards/test1"));
        deck.Add(Resources.Load<Card>("Cards/test2"));
        deck.Add(Resources.Load<Card>("Cards/test3"));
        deck.Add(Resources.Load<Card>("Cards/test4"));
        deck.Add(Resources.Load<Card>("Cards/test5"));

        shuffle();
        countUpdate();
       
       // update when change the number
    }
    private void Update() {
        // do nothing here
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
    public void drawCard()
    {
        Card tmp = deck.PopAt(deck.Count);
        countUpdate();
        //return tmp;
    }
    public int getRemain()
    {
        return numCardRemain;
    }
    private void countUpdate()
    {
        numCardRemain = deck.Count;
        remain.text = numCardRemain.ToString();
    }
    public void test()
    {
        Debug.Log("HI");
    }
}
