﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareStone : Unmovable
{
    protected override void Awake()
    {
        base.Awake();
        CanCatchFired = false;
        CanDestroyed = true;
        MaxIndureImpurse = 3;//temp value
    }
}
