﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CameraMove : MonoBehaviour
{
    public GameObject box;
    public GameObject box2;
    private const float moveSpeed = 4f;
    private const float cameraSpeed = 1f;
    private const float dashMultiplier = 2f; // Multiplier for dashing speed

    public Quaternion TargetRotation { private set; get; }

    private Vector3 moveVector = Vector3.zero;
    private float moveY = 0.0f;
    private bool isDashing = false; // Flag to check if dashing

    private new Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;

        TargetRotation = transform.rotation;
    }

    private void Update()
    {

        if (transform.position.z <= 30)
        {
            Vector3 newPosition = transform.position;
            newPosition.y = 1;
            transform.position = newPosition;
        }
        if (transform.position.z >= 59)
        {
            Vector3 newPosition = transform.position;
            newPosition.y = 1;
            transform.position = newPosition;
        }
        if (transform.position.z > 30 && transform.position.z<57)
        {
            if (transform.position.y >= -0.7f)
            {
                Vector3 newPosition = transform.position;
                newPosition.y = -0.7f;
                transform.position = newPosition;
            }
        }
        if (transform.position.y >= 1)
        {
            Vector3 newPosition = transform.position;
            newPosition.y = 1;
            transform.position = newPosition;
        }
        if (transform.position.x >= -85)
        {
            box.SetActive(true);
        }
        GameObject obj0 = GameObject.Find("door0 (1)");

        if(obj0 ==null && transform.position.x >=-40)
        {
            box2.SetActive(true);
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

        // Check if dash key is pressed
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isDashing = true;
            StartCoroutine(StopDash()); // Start coroutine to stop dashing after a certain duration
        }
    }

    private void FixedUpdate()
    {
        Vector3 newVelocity = transform.TransformDirection(moveVector);
        newVelocity.y += moveY;

        // Apply dash multiplier if dashing
        if (isDashing)
        {
            newVelocity *= dashMultiplier;
        }

        rigidbody.velocity = newVelocity;
    }

    private IEnumerator StopDash()
    {
        yield return new WaitForSeconds(0.5f); // Change the duration of the dash as desired

        // Stop dashing after the specified duration
        isDashing = false;
    }

    public void ResetTargetRotation()
    {
        TargetRotation = Quaternion.LookRotation(transform.forward, Vector3.up);
    }
}
