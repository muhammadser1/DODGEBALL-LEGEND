using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tesy : MonoBehaviour
{
    public Slider healthSlider;
    private int health = 110;



    void Start()
    {
        healthSlider.value = health;
    }
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.name == "ball0")
        {
            health -= 10;
            healthSlider.value = health;
        }
        if (other.gameObject.name == "ball01")
        {
            health -= 10;
            healthSlider.value = health;
        }
    }
}
