using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BarrierBlack : MonoBehaviour {

    public Text text1;

    public bool isMoveX=false;
    public bool isMoveY=false;

    public float moveDistanceX = 3.0f;
    public float moveDistanceY = 3.0f;

    //public GameObject red;
    // Use this for initialization
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        moveMent();
    }

    void moveMent()
    {
        if( isMoveX ) transform.position = new Vector3(Mathf.PingPong(Time.time, moveDistanceX), transform.position.y, transform.position.z);
        if( isMoveY ) transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, moveDistanceY)- 2.46f, transform.position.z);
    }

    void LoadScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "red" || collision.gameObject.tag == "blue")
        {
            text1.text = "You Lose!!!";
            Debug.Log("You lose");
            Invoke("LoadScene", 1.5f);
        }
        
    }

    private void OnTriggerStay(Collider collision)
    {
        if(collision.gameObject.tag != "red" && collision.gameObject.tag != "blue")
        {
            isMoveX = false;
            isMoveY = false;
            transform.position = collision.transform.position;
        }
        
    }

   
}
