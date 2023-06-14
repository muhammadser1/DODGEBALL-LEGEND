using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hp3 : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    private GameObject tombstoneObject;
    void Start()
    {
        currentHealth = maxHealth;
        healthSlider.maxValue = maxHealth;
        healthSlider.value = currentHealth;
    }
    void Update()
    {
        tombstoneObject = GameObject.Find("Enemylevel0 (10)a");
        if (currentHealth <= 0)// && !hasDivided)
        {

            if (tombstoneObject != null)
            {
                tombstoneObject.transform.position = gameObject.transform.position;
                Vector3 newPosition = tombstoneObject.transform.position;
                newPosition.y = 0; // Set the desired y-value
                tombstoneObject.transform.position = newPosition;
            }

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
