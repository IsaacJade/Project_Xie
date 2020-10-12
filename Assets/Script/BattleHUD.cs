using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
    public Text maxHpText;
    public Text HPText;

    public void SetHUD(Unit unit)
    {
        //nameText.text = Unit.unitName;
       // HPslider.maxVualue = Unit.maxHP;
        //HPslider.value = Unit.currentHP;
        maxHpText.text = unit.maxHP.ToString();
        HPText.text = unit.currentHP.ToString();
    }

    public void SetHP(int hp)
    {
        HPText.text = hp.ToString();
    }
}
