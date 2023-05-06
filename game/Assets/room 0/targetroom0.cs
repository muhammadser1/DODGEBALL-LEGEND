using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetroom0 : MonoBehaviour
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
        transform.position = startingPosition + new Vector3(0, 0f, x);
    }
}
