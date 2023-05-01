using UnityEngine;

public class BallPickup : MonoBehaviour
{



    public GameObject text;


    public GameObject ball;
    public Transform parent;
    public float pickupDistanceThreshold = 1f;
    public float throwForce = 20f;
    public float throwDistance = 10f;
    public float throwHeight = 1f; // added variable to set throw height
    public float gravity = -9.81f; // added variable to set gravity value
    public Camera cameraObject; // assign this in the inspector

    private Rigidbody ballRigidbody;
    private bool isEquipped = false;

    void Start()
    {
        text.SetActive(false);
       




        ballRigidbody = ball.GetComponent<Rigidbody>();
        ballRigidbody.isKinematic = true;
    }

    private void Update()
    {
        float distance = Vector3.Distance(ball.transform.position, parent.position);
        if(distance < 2f)
        {
          text.SetActive(true);
        }
        else
        {
            text.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {

            if (!isEquipped)
            {
               // float distance = Vector3.Distance(ball.transform.position, parent.position);
                if (distance < pickupDistanceThreshold)
                {
                    ball.transform.parent = parent;
                    ball.transform.localPosition = Vector3.zero;
                    ballRigidbody.isKinematic = true;
                    isEquipped = true;
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            if (isEquipped)
            {
                ball.transform.parent = null;
                ballRigidbody.isKinematic = false;
                Vector3 throwDirection = cameraObject.transform.forward;
                throwDirection.y = 0f; // set y component to 0
                throwDirection = throwDirection.normalized;
                Vector3 throwPosition = cameraObject.transform.position + throwDirection * throwDistance;

                // added code to set the ball's trajectory with a curve
                float throwDuration = throwDistance / throwForce;
                Vector3 throwVelocity = throwDirection * throwForce;
                throwVelocity.y = (throwHeight - throwPosition.y - 0.5f * gravity * throwDuration * throwDuration) / throwDuration;
                ballRigidbody.velocity = throwVelocity;
                ballRigidbody.useGravity = true;
                isEquipped = false;
            }
        }
    }
}
