using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class HPPlayer : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    public int hp1 = 0;
    public Slider healthSlider;

    private void Start()
    {
        currentHealth = maxHealth-10;
        UpdateHealthSlider();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            DecreaseHealth(10);
        }
     /*   hp1++;
        if (hp1 >= 10000)
        {
            currentHealth += 10;
            UpdateHealthSlider();
        }*/
        if (hp1 == 0)
        {
            UnityEngine.Debug.Log("Player x position: " + transform.position.x);
            UnityEngine.Debug.Log("Player y position: " + transform.position.y);
            UnityEngine.Debug.Log("Player z position: " + transform.position.z);

        
              if (transform.position.x >= -60 && transform.position.x <= -58)
              {
                  if (transform.position.y >= 0 && transform.position.y <= 2)
                  {
                      if (transform.position.z >= 0 && transform.position.z <= 2)
                      {
                          currentHealth += 10;
                          UpdateHealthSlider();
                          hp1++;
                          GameObject obj = GameObject.Find("Cube (6)1");

                          if (obj != null)
                          {
                              Destroy(obj);
                          }
                      }
                  }
              }
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
