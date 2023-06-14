using UnityEngine;

public class TowerRotation : MonoBehaviour
{
    public Transform player;
    public float rotationSpeed = 5f;
    public float detectionDistance = 15f;

    private void Update()
    {
        // Calculate the distance between the tower and the player
        float distance = Vector3.Distance(transform.position, player.position);

        // Check if the distance is less than or equal to the detection distance
        if (distance <= detectionDistance)
        {
            // Calculate the direction from the tower to the modified player position
            Vector3 direction = (new Vector3(player.position.x, player.position.y - 1f, player.position.z) - transform.position).normalized;

            // Calculate the target rotation based on the direction
            Quaternion targetRotation = Quaternion.LookRotation(direction);

            // Smoothly rotate the tower towards the target rotation
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
