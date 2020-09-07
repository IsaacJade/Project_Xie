using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardBack : MonoBehaviour
{
    public CardDisplay thisCard;
    public GameObject cardBack;

    private void Update() {
        if(thisCard.cardBack == true) 
        {
            cardBack.SetActive(true);
        }else
        {
            cardBack.SetActive(false);
        }
    }
}
