using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ball0" || collision.gameObject.name == "ball01"|| collision.gameObject.name == "ball02")
        {
            Destroy(gameObject); // Destroy the box game object
        }
    }
}
