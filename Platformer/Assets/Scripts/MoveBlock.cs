using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour {


    public delegate void isTouch();
    public static event isTouch Touch;


    // Use this for initialization
    void Start () {
		
	}
	
    


	// Update is called once per frame
	void Update () {
		
	}



    private void OnTriggerStay(Collider collision)
    {
        Touch();
    }

}
