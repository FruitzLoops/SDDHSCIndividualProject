using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class betterjump : MonoBehaviour
{
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
    bool jumpRequest;
    
    public float JumpForce = 1;



    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();


    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && ((rb.velocity.y > -0.99f) && (rb.velocity.y < 0.99f))) //button down and not falling or jumping already
        {
            jumpRequest = true;
        }
        if (rb.velocity.y < 0) // player is falling
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime; //makes the fall faster to make the jump feel more realistic
        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump")) //holding down button for bigger jump
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime; //makes gravity stronger player jumps higher
        }
    }

    void FixedUpdate() // happens right after update
    {
        if (jumpRequest)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse); //jump up by JumpForce
            jumpRequest = false;


        }
    }

    

   

}



