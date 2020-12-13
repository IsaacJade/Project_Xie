using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleHUD : MonoBehaviour
{
    public GameObject maxHp;
    public GameObject HP;
    private TextMeshProUGUI maxHpText;
    private TextMeshProUGUI HPText;

    void Start()
    {

    }
    public void SetHUD(Unit unit)
    {
        maxHpText = maxHp.GetComponent<TextMeshProUGUI>();
        HPText = HP.GetComponent<TextMeshProUGUI>();
        maxHpText.SetText(unit.maxHP.ToString());
        HPText.SetText(unit.currentHP.ToString());
    }

    public void SetHP(int hp)
    {
        HPText.text = hp.ToString();
    }
}
