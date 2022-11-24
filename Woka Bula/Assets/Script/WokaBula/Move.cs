using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move
{
    public Move_Base Base { get; set; }
    public int PP { get; set; }

    public Move(Move_Base pBase)
    {
        Base = pBase;
        PP = pBase.PP;
    }   
}
