using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Deck : MonoBehaviour
{
    public List<Card> active = new List<Card> ();
    private List<Card> reserve = new List<Card>();
    public List<Card> graveyard = new List<Card>();
    private int numCardRemain;
    public Card testCard;
    private void Awake()
    {
        reserve.Add(testCard);   
    }

    public void shuffle()
    {
        for (int i = 0; i < active.Count; i++) {
         Card temp = active[i];
         int randomIndex = Random.Range(i, active.Count);
         active[i] = active[randomIndex];
         active[randomIndex] = temp;
     }
    }
    public Card drawCard()
    {
        Card tmp = active.PopAt(active.Count);
        countUpdate();
        return tmp;
    }
    public int getRemain()
    {
        return numCardRemain;
    }
    private void countUpdate()
    {
        numCardRemain = active.Count;
    }

    public void AddToReserve(Card card)
    {
        reserve.Add(card);
    }
    public IEnumerator ReserveExecute()
    {
        foreach(Card card in reserve)
        {
            yield return card.execute();
            graveyard.Add(card);
        }
        reserve.Clear();
        yield return null;
    }

}
