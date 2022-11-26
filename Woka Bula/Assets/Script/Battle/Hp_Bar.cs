using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp_Bar : MonoBehaviour
{
    [SerializeField] GameObject health;


    private void Start()
    {
        health.transform.localScale = new Vector3(0.5f, 1);
    }
}
