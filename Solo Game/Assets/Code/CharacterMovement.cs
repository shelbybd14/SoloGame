using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;

    bool isGrounded;

    [SerializeField]
    Transform groundCheck;

    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    private void FixedUpdate()
    {
        if(Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground")))
        {
            isGrounded = true;
        }

        else
        {
            isGrounded = false;
        }
        if(Input.GetKey("d")|| Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(2,rb2d.velocity.y);

            if(isGrounded)
            animator.Play("walk_right");

            spriteRenderer.flipX = false;

        }
        else if(Input.GetKey("a")|| Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-2, rb2d.velocity.y);

            if (isGrounded)
                animator.Play("walk_right");

              spriteRenderer.flipX = true;
        }

        else
        {
            if (isGrounded)
                animator.Play("idle");

            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }

        if(Input.GetKey("space")&& isGrounded)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 3);
            animator.Play("jump");
        }
    }
}
