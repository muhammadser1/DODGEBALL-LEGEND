using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class room2hp : MonoBehaviour
{
    public GameObject text;
    public int maxHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    // Start is called before the first frame update
    void Start()
    {
        healthSlider.gameObject.SetActive(false); // to show the slider
        currentHealth = maxHealth;
        healthSlider.maxValue = maxHealth;
        healthSlider.value = currentHealth;
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        GameObject obj0 = GameObject.Find("Enemylevel0");
        GameObject obj2 = GameObject.Find("Enemylevel0 (1)");
        if (obj0 == null && obj2==null)
        {
            healthSlider.gameObject.SetActive(true); // to show the slider
            text.SetActive(true);

        }
        if (currentHealth <= 0)// && !hasDivided)
        {
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
