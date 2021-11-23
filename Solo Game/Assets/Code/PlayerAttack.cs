using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class PlayerAttack : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    void Attack()
    {
        //Play attack animation
        animator.SetTrigger("attack");

        //detect enemies in range
        //damage enemies

    }

       
}
   