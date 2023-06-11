using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class e1move : MonoBehaviour
{
    public Transform player;
    public float detectionDistance = 5f;
    public GameObject projectilePrefab;
    public float projectileSpeed = 10f;
    public float destroyDelay = 2f;

    private bool playerInRange = false;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (player == null)
        {
            //Debug.LogWarning("Player not found!");
            return;
        }

        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer < detectionDistance)
        {
            if (!playerInRange)
            {
                playerInRange = true;
                StartCoroutine(ShootProjectile());
            }
        }
        else
        {
            playerInRange = false;
        }
    }

    private IEnumerator ShootProjectile()
    {
        while (playerInRange)
        {
            GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            Rigidbody projectileRigidbody = projectile.GetComponent<Rigidbody>();
            Vector3 directionToPlayer = (player.position - transform.position).normalized;
            projectileRigidbody.velocity = directionToPlayer * projectileSpeed;

            yield return new WaitForSeconds(destroyDelay);

            Destroy(projectile);
        }
    }
}
