using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class PlayerAttack : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        if(Input.GetKey("space"))
        {
            Attack();
        }
    }

    void Attack()
    {
        //Play attack animation
        animator.Play("attack");

        //detect enemies in range
        //damage enemies

    }

       
}
   