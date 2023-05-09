using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door0 : MonoBehaviour
{
    public GameObject text;
    public GameObject healthBar;
    public GameObject text2;
    public GameObject healthBar2;
    void Start()
    {
        text.SetActive(false);
        healthBar.SetActive(false);
        text2.SetActive(false);
        healthBar2.SetActive(false);
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
                text.SetActive(true);
                healthBar.SetActive(true);
                text2.SetActive(true);
                healthBar2.SetActive(true);
            }
        }
        else
        {
            text.SetActive(false);
            healthBar.SetActive(false);
            text2.SetActive(false);
            healthBar2.SetActive(false);
        }

        if (obj0 == null && obj01 == null && obj02 == null)
        {
            Destroy(gameObject);
        }
    }
}
