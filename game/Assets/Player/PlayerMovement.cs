using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool dis = false;
    public GameObject text;
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20f;
    public float dashDistance = 3.0f;
    public float dashDuration = 0.2f;
    public float crouchHeight = 1.0f;
    public float standHeight = 2.0f;
    public float extraJumpForce = 5.0f; // extra force added to jump when player hits the box

    public float mouseSensitivity = 100.0f;
    public Transform cameraTransform;

    private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;
    private bool isDashing = false;
    private float dashTimer = 0.0f;
    private float originalHeight;
    private float xRotation = 0.0f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        originalHeight = controller.height;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        bool isJumping = Input.GetButtonDown("Jump");
        bool isDucking = Input.GetKey(KeyCode.LeftControl);
        bool isDashingInput = Input.GetKeyDown(KeyCode.LeftShift);
        if (!dis)
        {
            Vector3 moveInput = new Vector3(horizontalInput, 0f, verticalInput);
            moveInput = transform.TransformDirection(moveInput);
            moveInput *= speed;

            if (controller.isGrounded)
            {
                if (isJumping)
                {
                    moveDirection.y = jumpSpeed;
                }

                if (isDashingInput && !isDucking)
                {
                    isDashing = true;
                    dashTimer = 0.0f;
                    moveInput *= dashDistance;
                }
            }

            if (isDashing)
            {
                dashTimer += Time.deltaTime;
                if (dashTimer >= dashDuration)
                {
                    isDashing = false;
                }
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                text.SetActive(false);
            }

            // add extra jump force when player hits the box
            if (controller.isGrounded && Input.GetKeyDown(KeyCode.E))
            {
                if (transform.position.x > 30f && transform.position.x < 32f)
                {
                    if (transform.position.z > 16f && transform.position.z < 18f)
                    {
                        GameObject obj0 = GameObject.Find("Enemylevel0");
                        if (obj0 == null)
                        {
                            moveDirection.y = jumpSpeed + extraJumpForce;
                        }
                    }
                }
                      
            }

            moveDirection.y -= gravity * Time.deltaTime;

            if (isDucking)
            {
                controller.height = crouchHeight;
            }
            else
            {
                controller.height = standHeight;
            }

            controller.Move(moveInput * Time.deltaTime);

            if (isDashing)
            {
                controller.Move(moveInput * Time.deltaTime);
            }
            else
            {
                controller.Move(moveDirection * Time.deltaTime);
            }

            // Mouse movement
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90.0f, 90.0f);

            transform.Rotate(Vector3.up * mouseX);
            cameraTransform.localRotation = Quaternion.Euler(xRotation, 0.0f, 0.0f);
        }
    }
}
