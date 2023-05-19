using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class HPPlayer : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public Slider healthSlider;

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthSlider();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            DecreaseHealth(10);
        }
    }

    private void DecreaseHealth(int amount)
    {
        currentHealth -= amount;

        UpdateHealthSlider();
    }

    private void UpdateHealthSlider()
    {
        if (healthSlider != null)
        {
            healthSlider.value = currentHealth;
        }
    }
}
