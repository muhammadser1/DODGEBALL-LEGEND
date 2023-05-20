using UnityEngine;

public class chasing : MonoBehaviour
{
    public float speed = 5f;
    public float detectionRadius = 5f;
    private Transform playerTransform;
    private Rigidbody rb;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, playerTransform.position);

        if (distance <= detectionRadius)
        {
            // Calculate the direction towards the player
            Vector3 direction = (playerTransform.position - transform.position).normalized;

            // Cast a ray in the direction of movement to check for obstacles
            RaycastHit hit;
            if (Physics.Raycast(transform.position, direction, out hit, speed * Time.deltaTime))
            {
                // If an obstacle is detected, don't move the enemy
                return;
            }

            // Move the enemy towards the player
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
        }
    }
}
