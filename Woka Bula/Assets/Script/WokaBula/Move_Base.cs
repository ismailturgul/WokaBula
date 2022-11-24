using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static WokaBula_Base;

[CreateAssetMenu(fileName = "WokaBula", menuName = "WokaBula/Create new Move")]
public class Move_Base : ScriptableObject
{

    [SerializeField] string name;

    [TextArea]

    [SerializeField] string description;

    [SerializeField] WokaBulaType type;
    [SerializeField] int power;  // if said correct normal dmg, if not divide by 2
    [SerializeField] int accuracy; // if 3x in a row a correct answer, give a Bonus-dmg


    public string Name { get { return name; } }
    public string Description { get { return description; } }
    public WokaBulaType Type { get { return type; } }
    public int Power { get { return power; } }
    public int Accuracy { get { return accuracy; } }

}
