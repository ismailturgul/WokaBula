using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WokaBula", menuName = "WokaBula/Create new wokaBula")]
public class WokaBula_Base : ScriptableObject
{

    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;
    [SerializeField] Sprite front_Sprite;
    [SerializeField] Sprite back_Sprite;
    [SerializeField] WokaBulaType type1;
    [SerializeField] WokaBulaType type2;

    //Base Stats
    [SerializeField] int max_Hp;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int sp_Attack;
    [SerializeField] int sp_Defense;
    [SerializeField] int speed;


    [SerializeField] List<Learnable_Move> learnable_Moves;


    public string Name { get { return name; } }
    public string Description { get { return description; } }
    public Sprite Front_Sprite { get { return Front_Sprite; } }
    public Sprite Back_Sprite { get { return Back_Sprite; } }
    public WokaBulaType Type1 { get { return type1; } }
    public WokaBulaType Type2 { get { return type2; } }
    public int Max_Hp { get { return max_Hp; } }
    public int Attack { get { return attack; } }
    public int Defense { get { return defense; } }
    public int Sp_Attack { get { return sp_Attack; } }
    public int Sp_Defense { get { return sp_Defense; } }
    public int Speed { get { return speed; } }
    public List<Learnable_Move> Learnable_Moves { get { return learnable_Moves; } }

    [System.Serializable]
    public class Learnable_Move
    {
        [SerializeField] Move_Base move_Base;
        [SerializeField] int level;

        public Move_Base Base { get { return move_Base; } }
        public int Level { get { return level; } }
    }

    public enum WokaBulaType
    {
        None,
        Nomen,
        Substantiv,
        Adjektiv,
        Zahlwort,
        Pronomen,
        Verb,
        Partizip,
        Adv_Partizip,
        Adverb,
        Zustandswort
    }
}
