using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class towerhp : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;
    public Slider healthSlider;
    public float enemyDetectionRadius = 3f;
    void Start()
    {
        currentHealth = maxHealth;
        healthSlider.maxValue = maxHealth;
        healthSlider.value = currentHealth;
    }
    void Update()
    {
        // Check if an enemy is close and decrease health by 10 if there is
        Collider[] colliders = Physics.OverlapSphere(transform.position, enemyDetectionRadius);
        foreach (Collider collider in colliders)
        {

            if (collider.CompareTag("ball01"))
            {
                currentHealth -= 2f;
                healthSlider.value = currentHealth;
                break;
            }
            if (collider.CompareTag("ball0"))
            {
                currentHealth -= 3f;
                healthSlider.value = currentHealth;
                break;
            }
        }
        if (currentHealth <= 0)// && !hasDivided)
        {



            Destroy(gameObject);
        }
    }
    
}
