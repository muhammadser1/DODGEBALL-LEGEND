using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerclose : MonoBehaviour
{
    public GameObject text;
    public GameObject targetObject;
    public float detectionRadius = 2f;
    private ll script2; // Changed to private field
    private HPPlayer script1; // Changed to private field
    private void Start()
    {
        text.SetActive(false);
        script2  = GetComponent<ll>();
        script1 = GetComponent<HPPlayer>();

    }

    private void Update()
    {
        GameObject obj1 = GameObject.Find("Laser_Red (2)");
        GameObject obj2 = GameObject.Find("Laser_Red (3)");
        GameObject obj3 = GameObject.Find("Laser_Red (4)");
        GameObject obj4 = GameObject.Find("Laser_Red (5)");
        GameObject obj5 = GameObject.Find("Laser_Red (6)");
        GameObject obj6 = GameObject.Find("Laser_Red (7)");
        GameObject obj7 = GameObject.Find("Laser_Red (8)");
        GameObject obj8 = GameObject.Find("Laser_Red (9)");
        float distance = Vector3.Distance(transform.position, targetObject.transform.position);
        if (distance <= detectionRadius)
        {
            if (text != null)
                text.SetActive(true);
            if (Input.GetKeyDown(KeyCode.M))
            {
                if (obj1 != null)
                    Destroy(obj1);
                if (obj2 != null)
                    Destroy(obj2);
                if (obj3 != null)
                    Destroy(obj3);
                if (obj4 != null)
                    Destroy(obj4);
                if (obj5 != null)
                    Destroy(obj5);
                if (obj6 != null)
                    Destroy(obj6);
                if (obj7 != null)
                    Destroy(obj7);
                if (obj8 != null)
                    Destroy(obj8);

                if (text != null)
                    Destroy(text);

                // Update the variables in the HPPlayer script
                if(script2!=null)
                {
                    script2.laser12 = 1;               
                }
                if (script1 != null)
                {
                    script1.laser2 = 1;
                    script1.laser1 = 1;
                }
            }
        }
        else
        {
            if (text != null)
                text.SetActive(false);
        }
    }
}
