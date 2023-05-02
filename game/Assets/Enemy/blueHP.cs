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
        
    }
void OnCollisionEnter(Collision other)
{
   
    if (other.gameObject.name == "ball0")
    {
        health -= 10;
        healthSlider.value = health;
    }
}
}
