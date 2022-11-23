using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WokaBula_Base : MonoBehaviour
{

    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;
    [SerializeField] Sprite front_Sprite;
    [SerializeField] Sprite back_Sprite;
    [SerializeField] WokaBulaType type1;
    [SerializeField] WokaBulaType type2;
    

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