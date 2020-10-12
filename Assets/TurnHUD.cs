using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnHUD : MonoBehaviour
{
    public Text maxTurnText;
    public Text TurnText;

    public void SetHUD(int maxturn)
    {
        //nameText.text = Unit.unitName;
       // HPslider.maxVualue = Unit.maxHP;
        //HPslider.value = Unit.currentHP;
        maxTurnText.text = maxturn.ToString();
        TurnText.text = "1";
    }

    public void SetTurn(int turn)
    {
        TurnText.text = turn.ToString();
    }
}
