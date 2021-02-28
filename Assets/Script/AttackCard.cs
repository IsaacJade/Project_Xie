using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AttackCard : Card
{
    public int attack;
    public GameObject TransPrefab;
    public int unitscore;
    AttackCard(string Cardname, string Description, int ManaCost, Sprite art, int Attack, GameObject TransPrefab)
        :base(Cardname,Description,ManaCost,art)
    {
        this.attack = Attack;
        this.TransPrefab = TransPrefab;
    }

    public override void execute()
    {
        Debug.Log("Attack Card Execute");
        //QTETracker.InstantiateCircle(TransPrefab.GetComponent<CircleTrans>(), unitscore, attack);
        StartCoroutine(QTETracker.InstantiateCircle(TransPrefab.GetComponent<CircleTrans>(), unitscore, attack));
    }
}
