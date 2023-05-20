using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class redenemyhp : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Slider healthSlider;

    void Start()
    {
        currentHealth = maxHealth;
        healthSlider.maxValue = maxHealth;
        healthSlider.value = currentHealth;
    }
    void Update()
    {

        if (currentHealth <= 0)// && !hasDivided)
        {



            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("ball0"))
        {
            currentHealth -= 10;
            healthSlider.value = currentHealth;
        }
        if (other.gameObject.CompareTag("ball01"))
        {
            currentHealth -= 60;
            healthSlider.value = currentHealth;
        }

    }
}
