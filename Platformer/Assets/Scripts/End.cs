using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour {
    public int starNum;
    private bool isRed = false;
    private bool isBlue = false;

    public Text text1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Star.destory += toTheEnd;
		
	}
    
    void toTheEnd()
    {
        starNum--;
    }

    private void OnTriggerStay(Collider collision)
    {
        if(collision.gameObject.tag == "red")
        {
            isRed = true;
        }
        else if (collision.gameObject.tag == "blue")
        {
            isBlue = true;
        }

        if (starNum <= 0 && isRed && isBlue)
        {
            Debug.Log("You Win!");
            text1.text = "You Win!!!";
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "red")
        {
            isRed = false;
        }
        else if (collision.gameObject.tag == "blue")
        {
            isBlue = false;
        }
    }

}
