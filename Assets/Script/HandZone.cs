using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HandZone : MonoBehaviour
{
    private static HandZone pInstance;
    public Deck playerDeck;
    public List<Card> hand;
    public GridLayoutGroup layoutGroup;

    private void Awake()
    {
        if (pInstance != null && pInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

            pInstance = this;
        DontDestroyOnLoad(this.gameObject);
        
    }
    private static HandZone privGetInstance()
    {
        return pInstance;
    }

    public static void AddToHand(Card card)
    {
        HandZone handZone = privGetInstance();
        handZone.hand.Add(card);
        card.transform.SetParent(handZone.layoutGroup.transform);
    }
    public void SelectToReserve()
    {
        HandZone handZone = privGetInstance();
        handZone.playerDeck.AddToReserve(gameObject.GetComponent<Card>());
        
    }

}
