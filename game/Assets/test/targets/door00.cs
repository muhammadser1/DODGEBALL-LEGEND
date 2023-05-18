using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door00 : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        GameObject obj0 = GameObject.Find("test1");
        GameObject obj01 = GameObject.Find("test2");
        GameObject obj02 = GameObject.Find("test3");

        if (obj0 == null && obj01 == null && obj02 == null)
        {
            Destroy(gameObject);
        }
    }
}
