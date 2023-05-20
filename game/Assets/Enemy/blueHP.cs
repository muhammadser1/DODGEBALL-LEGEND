using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class blueHP : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Slider healthSlider;

    void Start()
    {
        healthSlider.gameObject.SetActive(false); // to show the slider
        currentHealth = maxHealth;
        healthSlider.maxValue = maxHealth;
        healthSlider.value = currentHealth;
    }
    void Update()
    {

        if (currentHealth <= 0)// && !hasDivided)
        {
            healthSlider.gameObject.SetActive(true); // to show the slider



            Destroy(gameObject);
        }
    }
void OnCollisionEnter(Collision other)
{
   
    if (other.gameObject.name == "ball0")
    {
            currentHealth -= 60;
        healthSlider.value = currentHealth;
    }
        if (other.gameObject.name == "ball01")
        {
            currentHealth -= 60;
            healthSlider.value = currentHealth;
        }
      
    }
}
