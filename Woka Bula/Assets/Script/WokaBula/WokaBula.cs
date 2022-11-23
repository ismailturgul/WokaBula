using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WokaBula
{
    WokaBula_Base _base;
    int level;

    public WokaBula(WokaBula_Base pbase, int plevel)
    {
        _base = pbase;
        level = plevel;
    }


    public int Attack
    {
        get { return Mathf.FloorToInt((_base.Attack * level) / 100f) + 5; }
    }
    public int Defense
    {
        get { return Mathf.FloorToInt((_base.Defense * level) / 100f) + 5; }
    }
    public int Sp_Attack
    {
        get { return Mathf.FloorToInt((_base.Sp_Attack * level) / 100f) + 5; }
    }
    public int Sp_Defense
    {
        get { return Mathf.FloorToInt((_base.Sp_Defense * level) / 100f) + 5; }
    }
    public int Speed
    {
        get { return Mathf.FloorToInt((_base.Speed * level) / 100f) + 5; }
    }
    public int Max_Hp
    {
        get { return Mathf.FloorToInt((_base.Max_Hp * level) / 100f) + 10; }
    }
}
