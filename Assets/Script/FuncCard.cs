﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncCard : Card
{
    //????
    FuncCard(string Cardname, string Description, int ManaCost, Sprite art)
    : base(Cardname, Description, ManaCost, art)
    {

    }

    public override void execute()
    {
        base.execute();
    }
}
