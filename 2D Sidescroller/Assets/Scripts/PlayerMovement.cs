﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;             //Floating point variable to store the player's movement speed.
    public float jumpForce;

    public bool isGrounded = false;

    public Vector3 jump;

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
        jump = new Vector3(0.0f, 2.0f);
    }

    private void OnTriggerStay2D()
    {
        isGrounded = true;

        if ((Input.GetKeyDown(KeyCode.Space) && (isGrounded == true)))
        {
            rb2d.AddForce(jump * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
            Debug.Log("Jump was pressed");
        }
    }
    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        rb2d.gravityScale = 2;

        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");

        //Store the current vertical input in the float moveVertical.
        //float moveVertical = Input.GetAxisRaw("Vertical");

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, 0);

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.AddForce(movement * speed);

        if ((Input.GetKey(KeyCode.S)))
        {
            rb2d.gravityScale = 5;
            Debug.Log("Fall was pressed");
        }
    }
}
