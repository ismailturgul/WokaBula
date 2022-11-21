using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float move_Speed;

    private bool is_Moving;
    private Vector2 input;

    void Update()
    {
        if (!is_Moving)
        {
            input.x = Input.GetAxisRaw("Horizontal");   // + or - value when pressed
            input.y = Input.GetAxisRaw("Vertical");     // + or - value when pressed

            if (input != Vector2.zero)
            {
                var target_Pos = transform.position;
                target_Pos.x += input.x;
                target_Pos.y += input.y;

                StartCoroutine(Move(target_Pos));
            }
        }
    }
    //chorotine
    IEnumerator Move(Vector3 target_Pos)
    {
        while ((target_Pos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {

            transform.position = Vector3.MoveTowards(transform.position, target_Pos, move_Speed * Time.deltaTime);
            yield return null;
        }
        transform.position = target_Pos;

        is_Moving = false;
    }
}
