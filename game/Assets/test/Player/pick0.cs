using UnityEngine;

public class pick0 : MonoBehaviour
{
    public string ballTag = "ball0"; // Tag assigned to the ball objects
    public Transform parent;
    public float pickupDistanceThreshold = 1f;
    public float throwForce = 20f;
    public float throwDistance = 10f;
    public float throwHeight = 1f; // added variable to set throw height
    public float gravity = -9.81f; // added variable to set gravity value
    public Camera cameraObject; // assign this in the inspector

    private Rigidbody ballRigidbody;
    private GameObject pickedBall;
    private bool isEquipped = false;

    private void Start()
    {
        ballRigidbody = null;
        pickedBall = null;
    }

    private void Update()
    {
        if (isEquipped)
        {
            // Handle any logic while the ball is equipped
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (!isEquipped && pickedBall == null)
            {
                Collider[] colliders = Physics.OverlapSphere(parent.position, pickupDistanceThreshold);
                foreach (Collider collider in colliders)
                {
                    if (collider.CompareTag(ballTag))
                    {
                        pickedBall = collider.gameObject;
                        ballRigidbody = pickedBall.GetComponent<Rigidbody>();
                        ballRigidbody.isKinematic = true;
                        pickedBall.transform.parent = parent;
                        pickedBall.transform.localPosition = Vector3.zero;
                        isEquipped = true;
                        break;
                    }
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            if (isEquipped && pickedBall != null)
            {
                ballRigidbody.isKinematic = false;
                pickedBall.transform.parent = null;
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
                pickedBall = null;
                ballRigidbody = null;
            }
        }
    }
}
