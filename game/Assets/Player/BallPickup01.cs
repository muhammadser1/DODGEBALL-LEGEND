using UnityEngine;

public class BallPickup01 : MonoBehaviour
{


    private oneball script2;

    public GameObject text;
    public GameObject text2;

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
        text2.SetActive(false);

        script2 = GetComponent<oneball>();


        ballRigidbody = ball.GetComponent<Rigidbody>();
        ballRigidbody.isKinematic = true;
    }

    private void Update()
    {
        if (isEquipped)
        {
            text2.SetActive(true);
            text.SetActive(false);
        }
        float distance = Vector3.Distance(ball.transform.position, parent.position);
        if (distance < 2f)
        {
            if (!isEquipped)
            {
                text.SetActive(true);
                text2.SetActive(false);
            }
        }
        else
        {
            text.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {

            if (!isEquipped && script2.flag == 0)
            {
                // float distance = Vector3.Distance(ball.transform.position, parent.position);
                if (distance < pickupDistanceThreshold)
                {
                    script2.flag = 1;
                    ball.transform.parent = parent;
                    ball.transform.localPosition = Vector3.zero;
                    ballRigidbody.isKinematic = true;
                    text.SetActive(false);
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
                script2.flag = 0;
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
