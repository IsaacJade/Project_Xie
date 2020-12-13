using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TurnHUD : MonoBehaviour
{
    public GameObject maxTurn;
    public GameObject turn;
    private TextMeshProUGUI maxTurnText;
    private TextMeshProUGUI TurnText;

    void Start()
    {

    }

    public void SetHUD(int maxturn)
    {
        //maxTurnText = maxTurn.GetComponent<TextMeshPro>();
        //TurnText = maxTurn.GetComponent<TextMeshPro>();
        //nameText.text = Unit.unitName;
        // HPslider.maxVualue = Unit.maxHP;
        //HPslider.value = Unit.currentHP;
        maxTurnText = maxTurn.GetComponent<TextMeshProUGUI>();
        TurnText = turn.GetComponent<TextMeshProUGUI>();
        maxTurnText.SetText(maxturn.ToString());
        //maxTurnText.text = maxturn.ToString();
        TurnText.text = "1";
    }

    public void SetTurn(int turn)
    {
        TurnText.text = turn.ToString();
    }
}
