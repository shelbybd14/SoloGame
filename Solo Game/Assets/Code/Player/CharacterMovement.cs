using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Rigidbody2D body;
    private Animator anim;
    private bool grounded;

    private void Awake()
    {
        //references components in unity 
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        //flip player sprite for the x axis
        if (horizontalInput > 0.01f)
            transform.localScale = Vector3.one;
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-1,1,1);

        if (Input.GetKey(KeyCode.W) &&grounded|| Input.GetKey(KeyCode.UpArrow) && grounded)
            Jump();

        anim.SetBool("walk_right", horizontalInput != 0);
        anim.SetBool("grounded", grounded);
        
        
    }
    private void Jump()
        {
            body.velocity = new Vector2(body.velocity.x, 5);
            grounded = false;
            anim.SetTrigger("jump");
        }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = true;
    }
}