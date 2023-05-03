using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{
    public GameObject text;
    void Start()
    {
        text.SetActive(false);
    }
    void Update()
    {
        GameObject obj0 = GameObject.Find("test1");
        GameObject obj01 = GameObject.Find("test2");
        GameObject obj02 = GameObject.Find("test3");

        if (obj0 == null && obj01 == null)
        {
            if (obj02 == null)
            {
                text.SetActive(true); // If all three objects are null, set the text object to active
            }
        }
        else
        {
            text.SetActive(false); // Otherwise, set the text object to inactive

        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ball0" || collision.gameObject.name == "ball01" || collision.gameObject.name == "ball02")
        {
            Destroy(gameObject); // Destroy the box game object
        }
    }
}
