using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;
  

    void Update()
    {
        if (Input.GetKey("space"))
        {
          
            animator.Play("attack");
        }
    }
}


   