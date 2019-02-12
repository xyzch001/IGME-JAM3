using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BarrierBlue : MonoBehaviour
{
    public Text text1;
    private bool isActive = true;
    Renderer barrier;
    //public GameObject red;
    // Use this for initialization
    void Start()
    {
        barrier = this.gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LoadScene2()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "red" && isActive)
        {
            text1.text = "You Lose!!!";
            Debug.Log("You lose");
            Invoke("LoadScene2", 1.5f);
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "blue")
        {
            isActive = false;
            Color barrierColor = barrier.material.color;
            barrierColor.a = Mathf.Lerp(barrierColor.a, 0.0f, Time.deltaTime);
            barrier.material.color = barrierColor;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "blue")
        {
            isActive = true;
            Color barrierColor = barrier.material.color;
            barrierColor.a = 1.0f;
            barrier.material.color = barrierColor;
        }
    }



}
