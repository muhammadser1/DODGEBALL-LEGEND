using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HPPlayer : MonoBehaviour
{

    public int maxHealth = 100;
    private float currentHealth;
     int hp1 = 0;
     int hp2 = 0;
     int hp3 = 0;
     int hp4 = 0;
     int hp5 = 0;
    int  hp6 = 0;
    public Slider healthSlider;
    public float enemyDetectionRadius = 3f; // The radius around the player in which an enemy can be detected
    private void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthSlider();
    }

    private void Update()
    {
        GameObject obj1 = GameObject.Find("Laser_Red (2)");

        if (healthSlider.value <= 0)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("Menu 1");

        }
        if (transform.position.y < -0.6f)
        {
            currentHealth -= 0.1f;
            healthSlider.value = currentHealth;
        }



       
        /*******************************************************************************/
        // Check if an enemy is close and decrease health by 10 if there is
        Collider[] colliders = Physics.OverlapSphere(transform.position, enemyDetectionRadius);
        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag("lineRenderer"))
            {
                currentHealth -= 100f;
                healthSlider.value = currentHealth;
                break;
            }
            if (collider.CompareTag("Enemylevel0"))
            {
                currentHealth -= 0.05f;
                healthSlider.value = currentHealth;
                break;
            }
            if (collider.CompareTag("Enemylevel0 (1)"))
            {
                currentHealth -= 0.05f;
                healthSlider.value = currentHealth;
                break;
            }
            if (collider.CompareTag("chaseandmoveenemy"))
            {
                currentHealth -= 0.5f;
                healthSlider.value = currentHealth;
                break;
            }
            if (collider.CompareTag("e1"))
            {
                currentHealth -= 0.05f;
                healthSlider.value = currentHealth;
                break;
            }
            if (collider.CompareTag("EE1"))
            {
                currentHealth -= 0.05f;
                healthSlider.value = currentHealth;
                break;
            }
            if (collider.CompareTag("t1"))
            {
                currentHealth -= 0.1f;
                healthSlider.value = currentHealth;
                break;
            }
        }

        /*******************************************************************************/


        if (transform.position.z >= 69.5f && transform.position.z <= 71)
        {
            if (obj1 != null)
            {
                    currentHealth -= 30f;
                    healthSlider.value = currentHealth;
            }
        }
        if (transform.position.z >= 73 && transform.position.z <= 74)
        {
            if (transform.position.x >= -177 && transform.position.x <= -175)
            {
                if (obj1 != null)
                {
                    currentHealth -= 30f;
                    healthSlider.value = currentHealth;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            DecreaseHealth(10);
        }
        if (hp5 == 0)
        {

            if (transform.position.x >= -67 && transform.position.x <= -66)
            {
                if (transform.position.y >= 0 && transform.position.y <= 2)
                {
                    if (transform.position.z >= 2 && transform.position.z <= 4)
                    {
                        currentHealth = 100;
                        UpdateHealthSlider();
                        hp5++;
                        GameObject obj = GameObject.Find("Bottle_Endurance");

                        if (obj != null)
                        {
                            Destroy(obj);
                        }
                    }
                }
            }
        }
        if (hp1 == 0)
        {

            if (transform.position.x >= -111 && transform.position.x <= -110)
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
       // UnityEngine.Debug.Log("Player x position: " + transform.position.x);
     //   UnityEngine.Debug.Log("Player z position: " + transform.position.z);
        if (hp2 == 0)
        {
          
           UnityEngine.Debug.Log("Player y position: " + transform.position.y);
            UnityEngine.Debug.Log("Player z position: " + transform.position.z);
            UnityEngine.Debug.Log("Player x position: " + transform.position.x);


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


            if (transform.position.x >= 3 && transform.position.x <= 4)
            {

                if (transform.position.y >= 5 && transform.position.y <= 5.5)
                {
                    if (transform.position.z >= 19 && transform.position.z <= 20)
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


            if (transform.position.x >= 33 && transform.position.x <= 34)
            {

                if (transform.position.y >= 0 && transform.position.y <= 2)
                {
                    if (transform.position.z >= 7 && transform.position.z <= 8)
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
        if (hp6 == 0)
        {
            if (transform.position.x >= -9.2 && transform.position.x <= -8.7)
            {
                if (transform.position.y >= 0 && transform.position.y <= 2)
                {
                    if (transform.position.z >= 26 && transform.position.z <= 27)
                    {
                        currentHealth = 100;
                        UpdateHealthSlider();
                        hp6++;
                        GameObject obj = GameObject.Find("Bottle_Endurance (1)");

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
