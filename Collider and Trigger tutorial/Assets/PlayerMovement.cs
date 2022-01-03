using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	///for movement player
    private Rigidbody2D rb2D;
    public float speedMove;
    private Vector2 movement;
	
	///for detect ground when want to jump
	public int jumpForce;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool isGrounded;

    void Start()
    {
        ///get component rigidbody on this
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        ///input Left Right or Keys A D to movement horizontal
        movement.x = Input.GetAxisRaw("Horizontal");

        //script for jump when press key uparrow and in ground
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            rb2D.velocity = Vector2.up * jumpForce;
        }

        ///tranform the face player left and right follow mouse pointer
        Vector3 MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (MousePosition.x > transform.position.x)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else if (MousePosition.x < transform.position.x)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
    }

    private void FixedUpdate()
    {
        ///for move the player with rigidbody to left and right
        rb2D.velocity = new Vector2(movement.x * speedMove, rb2D.velocity.y);
		
        ///check player when is grounded true
		isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }
}
