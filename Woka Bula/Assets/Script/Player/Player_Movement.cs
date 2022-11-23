using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float move_Speed;
    public LayerMask solid_Objects_Layer;

    private bool is_Moving;
    private Vector2 input;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
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
                animator.SetFloat("move_X", input.x);
                animator.SetFloat("move_Y", input.y);


                var target_Pos = transform.position;
                target_Pos.x += input.x;
                target_Pos.y += input.y;
                if (Is_Walkable(target_Pos))
                 StartCoroutine(Move(target_Pos));
            }
        }
        animator.SetBool("is_Moving", is_Moving);
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
    private bool Is_Walkable(Vector3 target_Pos)
    {
       if(Physics2D.OverlapCircle(target_Pos, 0.2f, solid_Objects_Layer) != null)
        {
            return false;
        }
        return true;
    }
}
