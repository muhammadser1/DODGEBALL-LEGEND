using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current position of the object
        Vector3 currentPosition = transform.position;

        // Set the Y-coordinate to 0
        currentPosition.y = 0f;

        // Update the object's position
        transform.position = currentPosition;
    }
}
