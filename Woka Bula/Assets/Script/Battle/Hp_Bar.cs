using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp_Bar : MonoBehaviour
{
    [SerializeField] GameObject health;


    public void Set_HP(float hp_Normalized)
    {
        health.transform.localScale = new Vector3(hp_Normalized, 1);
    }


}
