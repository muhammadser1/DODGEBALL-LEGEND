using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalhint : MonoBehaviour
{
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject obj0 = GameObject.Find("test1");
        GameObject obj01 = GameObject.Find("test2");
        GameObject obj02 = GameObject.Find("test3");

        if (obj0 == null && obj01 == null && obj02 == null)
        {
            text.SetActive(true);
        }
    }
}
