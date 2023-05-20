using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject obj0 = GameObject.Find("Enemylevel0 (1)");
        GameObject obj01 = GameObject.Find("Enemylevel0");
        if (obj0 == null && obj01 ==null)
        {
            Destroy(gameObject);
        }
    }
}
