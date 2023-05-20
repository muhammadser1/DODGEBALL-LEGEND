using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CameraMove : MonoBehaviour
{
    private const float moveSpeed = 4f;
    private const float cameraSpeed = 1f;

    public Quaternion TargetRotation { private set; get; }

    private Vector3 moveVector = Vector3.zero;
    private float moveY = 0.0f;

    private new Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;

        TargetRotation = transform.rotation;
    }
    private void Update()
    {
        if (transform.position.y !=1)
        {
            Vector3 newPosition = transform.position;
            newPosition.y =1;
            transform.position = newPosition;
        }

        // Rotate the camera.
        var rotation = new Vector2(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"));
        var targetEuler = TargetRotation.eulerAngles + (Vector3)rotation * cameraSpeed;
        if (targetEuler.x > 180.0f)
        {
            targetEuler.x -= 360.0f;
        }
        targetEuler.x = Mathf.Clamp(targetEuler.x, -75.0f, 75.0f);
        TargetRotation = Quaternion.Euler(targetEuler);

        transform.rotation = Quaternion.Slerp(transform.rotation, TargetRotation,
            Time.deltaTime * 15.0f);

        // Move the camera.
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        moveVector = new Vector3(x, 0.0f, z) * moveSpeed;

        // Check if jump key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Apply an upward force to the rigidbody to simulate a jump
            rigidbody.AddForce(transform.up * 10f, ForceMode.Impulse);

            // Reset the moveY variable to prevent the camera from moving up
            moveY = 0f;
        }
        else
        {
            // Move the camera upwards when space bar is pressed.
            moveY = Input.GetKey(KeyCode.Space) ? moveSpeed : 0.0f;
        }
    }

    private void FixedUpdate()
    {
        Vector3 newVelocity = transform.TransformDirection(moveVector);
        newVelocity.y += moveY;
        rigidbody.velocity = newVelocity;
    }

    public void ResetTargetRotation()
    {
        TargetRotation = Quaternion.LookRotation(transform.forward, Vector3.up);
    }
}