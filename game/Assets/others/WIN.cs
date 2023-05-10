using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using static System.Net.Mime.MediaTypeNames;

public class WIN : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // GameObject obj0 = GameObject.Find("Enemylevel0");
        GameObject obj01 = GameObject.Find("Capsule");
        GameObject obj02 = GameObject.Find("Capsule (1)");
        GameObject obj03 = GameObject.Find("Capsule (2)");
        if (obj02 == null && obj01 == null && obj03==null)
        {

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(3);
        }    
    }
}
