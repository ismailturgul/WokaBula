using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WokaBula
{
    WokaBula_Base _base;  // reference a script
    int level;

    public int HP { get; set; }
    public List<Move> Move { get; set; }

    public WokaBula(WokaBula_Base pbase, int plevel)
    {
        _base = pbase;
        level = plevel;
        HP = _base.Max_Hp;

        Move= new List<Move>();
        foreach(var move in _base.Learnable_Moves)
        {
            if(move.Level <=level)
                Move.Add(new Move(move.Base));
            if (Move.Count >= 4)
                break;
        }
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
