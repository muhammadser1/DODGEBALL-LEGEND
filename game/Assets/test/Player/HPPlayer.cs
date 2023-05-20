using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class HPPlayer : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    public int hp1 = 0;
    public int hp2 = 0;
    public int hp3 = 0;
    public int hp4 = 0;
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

        if (hp1 == 0)
        {


        
              if (transform.position.x >= -60 && transform.position.x <= -58)
              {
                  if (transform.position.y >= 0 && transform.position.y <= 2)
                  {
                      if (transform.position.z >= 0 && transform.position.z <= 2)
                      {
                          currentHealth += 10;
                          UpdateHealthSlider();
                          hp1++;
                          GameObject obj = GameObject.Find("Bottle_Health");

                          if (obj != null)
                          {
                              Destroy(obj);
                          }
                      }
                  }
              }
        }
        UnityEngine.Debug.Log("Player x position: " + transform.position.x);
        UnityEngine.Debug.Log("Player z position: " + transform.position.z);
        if (hp2 == 0)
        {
          
            //UnityEngine.Debug.Log("Player x position: " + transform.position.x);


            if (transform.position.x >= 28f && transform.position.x <= 28.5f)
            {

                if (transform.position.y >= 0 && transform.position.y <= 2)
                {
                   if (transform.position.z >= 22 && transform.position.z <= 23.2f)
                    {
                        currentHealth += 10;
                        UpdateHealthSlider();
                        hp2++;
                        GameObject obj = GameObject.Find("Bottle_Health (1)");

                        if (obj != null)
                        {
                            Destroy(obj);
                        }
                   }
                }
            }
        }
        if (hp3 == 0)
        {

            //UnityEngine.Debug.Log("Player x position: " + transform.position.x);


            if (transform.position.x >= 36 && transform.position.x <= 36.5)
            {

                if (transform.position.y >= 0 && transform.position.y <= 2)
                {
                    if (transform.position.z >= 37 && transform.position.z <= 38)
                    {
                        currentHealth += 10;
                        UpdateHealthSlider();
                        hp3++;
                        GameObject obj = GameObject.Find("Bottle_Health (3)");

                        if (obj != null)
                        {
                            Destroy(obj);
                        }
                    }
                }
            }
        }
        if (hp4 == 0)
        {

            //UnityEngine.Debug.Log("Player x position: " + transform.position.x);


            if (transform.position.x >= 30 && transform.position.x <= 31)
            {

                if (transform.position.y >= 0 && transform.position.y <= 2)
                {
                    if (transform.position.z >= 44 && transform.position.z <= 45)
                    {
                        currentHealth += 10;
                        UpdateHealthSlider();
                        hp4++;
                        GameObject obj = GameObject.Find("Bottle_Health (2)");

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
