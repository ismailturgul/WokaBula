using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Battle_HUD : MonoBehaviour
{

    [SerializeField] Text name_Text;
    [SerializeField] Text level_Text;
    [SerializeField] Text hp_Bar;

    public void SetData(WokaBula wokabula)
    {
        name_Text.text = wokabula.Base.Name;
        level_Text.text = "Lvl" + wokabula.Level;
        hp_Bar.SetHP((float) wokabula.HP / wokabula.Max_Hp); 

    }
}
