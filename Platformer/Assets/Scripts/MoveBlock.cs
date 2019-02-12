using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour {

    private bool isMove = false;
    //public delegate void isTouch();
    //public static event isTouch Touch;
    

    // Use this for initialization
    void Start () {
		
	}
	
    


	// Update is called once per frame
	void Update () {
		
	}

    public bool getIsMove()
    {
        return isMove;
    }

    private void OnTriggerStay(Collider collision)
    {
        isMove = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isMove = false;
    }

}
