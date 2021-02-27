using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BuffCard : Card
{
    public int EffectTurns;
    public int EffectValue;
    BuffCard(string Cardname, string Description, int ManaCost, Sprite art, int turns, int value)
        : base(Cardname, Description, ManaCost, art)
    {
        this.EffectTurns = turns;
        this.EffectValue = value;
    }

    public override void execute()
    {
        base.execute();
    }
}
