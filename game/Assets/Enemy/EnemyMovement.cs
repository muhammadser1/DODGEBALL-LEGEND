using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private void Update()
    {
        // Move the robot in the positive X direction
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }
}
