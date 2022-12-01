using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WokaBula
{
    public WokaBula_Base Base { get; set; }  // reference a script (script name + variable for it )
    public int Level { get; set; }

    public int HP { get; set; }
    public List<Move> Move { get; set; }

    public WokaBula(WokaBula_Base pbase, int plevel)
    {
        Base = pbase;
        Level = plevel;
        HP = Max_Hp;

        Move= new List<Move>();
        foreach(var move in Base.Learnable_Moves)
        {
            if(move.Level <=Level)
                Move.Add(new Move(move.Base));
            if (Move.Count >= 4)
                break;
        }
    }


    public int Attack
    {
        get { return Mathf.FloorToInt((Base.Attack * Level) / 100f) + 5; }
    }
    public int Defense
    {
        get { return Mathf.FloorToInt((Base.Defense * Level) / 100f) + 5; }
    }
    public int Sp_Attack
    {
        get { return Mathf.FloorToInt((Base.Sp_Attack * Level) / 100f) + 5; }
    }
    public int Sp_Defense
    {
        get { return Mathf.FloorToInt((Base.Sp_Defense * Level) / 100f) + 5; }
    }
    public int Speed
    {
        get { return Mathf.FloorToInt((Base.Speed * Level) / 100f) + 5; }
    }
    public int Max_Hp
    {
        get { return Mathf.FloorToInt((Base.Max_Hp * Level) / 100f) + 10; }
    }
}
