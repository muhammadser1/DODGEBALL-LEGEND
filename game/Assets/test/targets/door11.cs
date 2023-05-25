using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door11 : MonoBehaviour
{
 //   private counter counterScript;
    // Start is called before the first frame update
    void Start()
    {
      //  counterScript = GameObject.FindObjectOfType<counter>();

    }

    // Update is called once per frame
    void Update()
    {
        GameObject obj0 = GameObject.Find("Enemylevel0 (1)");
        GameObject obj01 = GameObject.Find("Enemylevel0");
        if (obj0 == null && obj01 ==null)
        {
        //    counterScript.counterText = "aaa";
            Destroy(gameObject);
        }
    }
}
