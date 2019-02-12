using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public float speed;             //Floating point variable to store the player's movement speed.

    public bool isCharacter;

    public float verticalSpeed;

    private Rigidbody rb;       //Store a reference to the Rigidbody2D component required to use 2D Physics.


    private bool isGrounded = true;

    // Use this for initialization
    void Start()
    {
        Screen.SetResolution(1920, 1080, true);
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb = GetComponent<Rigidbody>();


    }



    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        isGrounded = Physics.Raycast(transform.position, -Vector3.up, 1.0f);


        if (isCharacter) Movement();
        else Movement2();

    }

    void Movement()
    {

        if (Input.GetKey(KeyCode.A))
        {
            ////Store the current horizontal input in the float moveHorizontal.
            //float moveHorizontal = Input.GetAxis("Horizontal");

            ////Store the current vertical input in the float moveVertical.
            //float moveVertical = Input.GetAxis("Vertical");


            transform.Translate(-Vector3.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }




        //Use the two store floats to create a new Vector2 variable movement.
        //Vector3 movement = new Vector3(moveHorizontal * speed * Time.deltaTime, 0.0f, 0.0f);
        Vector2 movement1 = new Vector3(0.0f, 1.0f, 0.0f);
        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.





        if (Input.GetKey(KeyCode.W) && isGrounded)
        {
            rb.AddForce(movement1 * verticalSpeed);

        }
    }

    void Movement2()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            ////Store the current horizontal input in the float moveHorizontal.
            //float moveHorizontal = Input.GetAxis("Horizontal");

            ////Store the current vertical input in the float moveVertical.
            //float moveVertical = Input.GetAxis("Vertical");


            transform.Translate(-Vector3.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }




        //Use the two store floats to create a new Vector2 variable movement.
        //Vector3 movement = new Vector3(moveHorizontal * speed * Time.deltaTime, 0.0f, 0.0f);
        Vector2 movement1 = new Vector3(0.0f, 1.0f, 0.0f);
        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.





        if (Input.GetKey(KeyCode.UpArrow) && isGrounded)
        {
            rb.AddForce(movement1 * verticalSpeed);

        }
    }


    
 
}
