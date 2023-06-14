using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practicehint : MonoBehaviour
{
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            text.SetActive(false);
        }
    }
}
