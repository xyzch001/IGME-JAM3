using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public float speed;             //Floating point variable to store the player's movement speed.

    public bool isCharacter;

    public float verticalSpeed;

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    private bool isGrounded = true;

    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();

        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        isGrounded = true;
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        if (isCharacter) Movement();
        else Movement2();

    }

    void Movement()
    {

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            //Store the current horizontal input in the float moveHorizontal.
            float moveHorizontal = Input.GetAxis("Horizontal");

            //Store the current vertical input in the float moveVertical.
            float moveVertical = Input.GetAxis("Vertical");


            transform.Translate(Vector3.right * moveHorizontal * speed * Time.deltaTime);
        }




        //Use the two store floats to create a new Vector2 variable movement.
        //Vector3 movement = new Vector3(moveHorizontal * speed * Time.deltaTime, 0.0f, 0.0f);
        Vector2 movement1 = new Vector2(0.0f, 1.0f);
        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.

        



        if (Input.GetKey(KeyCode.W) && isGrounded)
        {
            rb2d.AddForce(movement1 * verticalSpeed);
            isGrounded = false;
        }
    }

    void Movement2()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            //Store the current horizontal input in the float moveHorizontal.
            float moveHorizontal = Input.GetAxis("Horizontal");

            //Store the current vertical input in the float moveVertical.
            float moveVertical = Input.GetAxis("Vertical");


            transform.Translate(Vector3.right * moveHorizontal * speed * Time.deltaTime);
        }




        //Use the two store floats to create a new Vector2 variable movement.
        //Vector3 movement = new Vector3(moveHorizontal * speed * Time.deltaTime, 0.0f, 0.0f);
        Vector2 movement1 = new Vector2(0.0f, 1.0f);
        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.





        if (Input.GetKey(KeyCode.UpArrow) && isGrounded)
        {
            rb2d.AddForce(movement1 * verticalSpeed);
            isGrounded = false;
        }
    }

 
}
