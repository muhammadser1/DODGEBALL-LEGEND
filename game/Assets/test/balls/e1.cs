using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class e1 : MonoBehaviour
{
    public float lifetime;
    public float followDistance;
    private Vector3 startPosition;
    private float startTime;

    void Start()
    {
        startPosition = transform.position;
        startTime = Time.time;
    }

    void Update()
    {
        if (Time.time - startTime >= lifetime)
        {
            transform.position = startPosition;
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            if (rigidbody != null)
            {
                rigidbody.velocity = Vector2.zero;
            }
            startTime = Time.time;
        }

        GameObject player = GameObject.Find("PlayerCamera");
        GameObject enemy = GameObject.Find("EE1");
        if (player != null && enemy != null)
        {
            Vector3 playerPosition = player.transform.position;
            Vector3 enemyPosition = enemy.transform.position;

            float distance = Vector3.Distance(playerPosition, enemyPosition);

            if (distance <= followDistance)
            {
                Vector3 direction = playerPosition - transform.position;
                direction.Normalize();

                Rigidbody rigidbody = GetComponent<Rigidbody>();
                if (rigidbody != null)
                {
                    rigidbody.velocity = direction * 10;
                }
            }
        }
    }
}

