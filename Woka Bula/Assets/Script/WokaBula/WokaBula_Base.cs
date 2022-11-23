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
