using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierBlack : MonoBehaviour {

    private bool isActive = true;
    
    //public GameObject red;
    // Use this for initialization
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision)
        {
            Debug.Log("You lose");
        }
    }

   
}
