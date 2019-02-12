using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public MoveBlock switcher;

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        //MoveBlock.Touch += Movement;
        if (switcher.getIsMove()) Movement();

        
    }

    void Movement()
    {
        transform.position = new Vector3(transform.position.x,Mathf.Lerp(transform.position.y, Mathf.PingPong(Time.time, 6.0f) - 1.0f, Time.deltaTime ), transform.position.z);
    }
    
   

}
