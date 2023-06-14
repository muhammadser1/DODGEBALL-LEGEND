using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target3 : MonoBehaviour
{

    void Start()
    {
    }
    void Update()
    {
        GameObject obj0 = GameObject.Find("test1");
        GameObject obj01 = GameObject.Find("test2");
        GameObject obj02 = GameObject.Find("test3");

        

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ball0") || collision.gameObject.CompareTag("ball01"))
        {
            Destroy(gameObject); // Destroy the box game object
        }
    }

}
