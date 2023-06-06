using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightleft : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 4f;

    private Vector3 startingPosition;

    void Start()
    {
        startingPosition = transform.position;
    }

    void Update()
    {
        float x = Mathf.PingPong(Time.time * speed, distance);
        GameObject obj01 = GameObject.Find("Enemylevel0");
        if (obj01 == null)
        transform.position = startingPosition + new Vector3(x, 0f, 0);
    }
}
