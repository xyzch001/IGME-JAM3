using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        MoveBlock.Touch += Movement;
        
    }

    void Movement()
    {
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, 4.0f) - 0.282f , transform.position.z);
    }
    
    void OnDisable()
    {
        MoveBlock.Touch -= Movement;
    }

}
