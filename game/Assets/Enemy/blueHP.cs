using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class blueHP : MonoBehaviour
{ 

    public Slider healthSlider;
private int health = 100;
// Start is called before the first frame update
void Start()
    {
    healthSlider.value = health;
}

    // Update is called once per frame
    void Update()
    {
       if(health<=0)
        {
            GameObject obj = GameObject.Find("door0");

            if (obj != null)
            {
                Destroy(obj);
            }
        }
    }
void OnCollisionEnter(Collision other)
{
   
    if (other.gameObject.name == "ball0")
    {
        health -= 20;
        healthSlider.value = health;
    }
        if (other.gameObject.name == "ball01")
        {
            health -= 10;
            healthSlider.value = health;
        }
    }
}
