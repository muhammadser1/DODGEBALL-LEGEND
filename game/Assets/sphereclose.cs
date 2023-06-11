using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class sphereclose : MonoBehaviour
{
  /*  public string sphere4Name = "Sphere (4)"; // The name of the Sphere (4) GameObject
    public Material greenMaterial; // Reference to the green material for the box

    private Material originalMaterial; // Reference to the original material of the box
    private Renderer boxRenderer; // Reference to the box's renderer component
    private GameObject sphere4; // Reference to the Sphere (4) GameObject

    private float detectionRadius = 5f; // The radius within which the Sphere (4) is considered close
  */
    void Start()
    {
     /*   // Get the renderer component of the box
        boxRenderer = GetComponent<Renderer>();

        // Store the original material of the box
        originalMaterial = boxRenderer.material;

        // Find the Sphere (4) GameObject by name
        sphere4 = GameObject.Find(sphere4Name);

        if (sphere4 == null)
        {
            
        }*/
    }

    void Update()
    {/*   GameObject obj0 = GameObject.Find("Cube (34)");
        GameObject obj1 = GameObject.Find("Cube (35)");
        GameObject obj2 = GameObject.Find("Cube (36)");
        GameObject obj3 = GameObject.Find("Cube (37)");
        if (sphere4 != null)
        {
            // Calculate the distance between the box and the Sphere (4)
            float distance = Vector3.Distance(transform.position, sphere4.transform.position);

            // Check if the Sphere (4) is close to the box
            if (distance <= detectionRadius)
            {
                // Change the material of the box to green
                boxRenderer.material = greenMaterial;
                if (sphere4 != null)
                {
                    Destroy(sphere4);
                }
                if (obj0 != null)
                {
                    Destroy(obj0);
                }
                if (obj1 != null)
                {
                    Destroy(obj1);
                }
                if (obj2 != null)
                {
                    Destroy(obj2);
                }
                if (obj3 != null)
                {
                    Destroy(obj3);
                }
            }
           
        }*/
    }
}
