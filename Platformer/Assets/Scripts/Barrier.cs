using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour {

    private bool isActive = true;
    Renderer barrier;
    //public GameObject red;
	// Use this for initialization
	void Start () {
        barrier = this.gameObject.GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if(collision.gameObject.tag == "blue" && isActive)
        {
            Debug.Log("You lose");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "red")
        {
            isActive = false;
            Color barrierColor = barrier.material.color;
            barrierColor.a = Mathf.Lerp(barrierColor.a, 0.5f, Time.deltaTime);
            barrier.material.color = barrierColor;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "red")
        {
            isActive = true;
            Color barrierColor = barrier.material.color;
            barrierColor.a = 1.0f;
            barrier.material.color = barrierColor;
        }
    }

   

}
