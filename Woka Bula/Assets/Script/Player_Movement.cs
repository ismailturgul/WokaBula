using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float move_Speed;

    private bool is_Moving;
    private Vector2 input;

    private void Update()
    {
        if (!is_Moving)
        {
            input.x = Input.GetAxisRaw("Horizontal");   // + or - value when pressed
            input.y = Input.GetAxisRaw("Vertical");     // + or - value when pressed

            // removes diagonal movement !
            if (input.x != 0) input.y = 0;

            // if player moves, set the x + y position to the current position
            if (input != Vector2.zero)
            {
                var target_Pos = transform.position;
                target_Pos.x += input.x;
                target_Pos.y += input.y;
                Debug.Log("was geht ?");
                StartCoroutine(Move(target_Pos));
            }
        }
    }
    //corotine for movement
    IEnumerator Move(Vector3 target_Pos)
    {
        is_Moving= true;
        while ((target_Pos - transform.position).sqrMagnitude > Mathf.Epsilon)  // while current and target position is bigger then 0 ( so, while the player is moving)
        {

            transform.position = Vector3.MoveTowards(transform.position, target_Pos, move_Speed * Time.deltaTime); // add velocity to the movement
            yield return null;
        }
        transform.position = target_Pos;  // target position is now current position

        is_Moving = false; // player stops moving
    }
}
