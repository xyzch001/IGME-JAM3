using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour {

    public delegate void isDedtory();
    public static event isDedtory destory;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collision)
    {
        destory();
        if (collision)
        {
            Destroy(this.gameObject);
        }
    }
}
