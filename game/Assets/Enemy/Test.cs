using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
public class Test : MonoBehaviour
{
    // Initialize variables
    public float speed; // The speed at which the ball moves
    public float lifetime; // The time that the ball exists before being destroyed
    public GameObject enemy; // The enemy object to follow

    void Start()
    {
        // Find the enemy objec

        // Destroy the ball after the specified lifetime
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        // Check if the enemy object exists
        if (enemy != null)
        {
            // Calculate the direction to the enemy
            Vector3 direction = (enemy.transform.position - transform.position).normalized;

            // Set the velocity of the ball towards the enemy
            GetComponent<Rigidbody>().velocity = direction * speed;
        }
        else
        {
            // Log an error if the enemy object is missing

        }
    }
}
