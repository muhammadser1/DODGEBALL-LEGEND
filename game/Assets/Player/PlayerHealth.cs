using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class PlayerHealth : MonoBehaviour
{
    int hp1 = 0;
    int hp2 = 0;
    int hp3 = 0;
    int hp4 = 0;
    public Slider healthSlider;
    private float health = 100;
    public float enemyDetectionRadius = 3f; // The radius around the player in which an enemy can be detected

    void Start()
    {
        // Set the initial value of the health slider to 100
        healthSlider.value = health;
    }

    void Update()
    {
        if (transform.position.x >= 30 && transform.position.x <= 32)
        {
            if (transform.position.y >= 0 && transform.position.y <= 2)
            {
                if (transform.position.z >= 0 && transform.position.z <= 2)
                {
                    health += 0.01f;
                    healthSlider.value = health;
                   
                }
            }
        }
        // Check for jump input and decrease health by 10
      /* if (Input.GetKeyDown(KeyCode.Space))
        {
            health -= 10;
            healthSlider.value = health;
        }*/

        // Check if an enemy is close and decrease health by 10 if there is
        Collider[] colliders = Physics.OverlapSphere(transform.position, enemyDetectionRadius);
        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag("Enemylevel0"))
            {
                health -= 0.1f;
                healthSlider.value = health;
                break;
            }
            if (collider.CompareTag("Enemylevel2"))
            {
                health -= 0.2f;
                healthSlider.value = health;
                break;
            }
            if (collider.CompareTag("enemy1"))
            {
                health -= 0.1f;
                healthSlider.value = health;
                break;
            }
            if (collider.CompareTag("enemy3"))
            {
                health -= 0.1f;
                healthSlider.value = health;
                break;
            }
        }

        // Check if health has reached 0 and restart game if it has
        if (health <= 0)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(2);
            // This line loads the scene

        }

        // Check if player has touched a health pickup
        if (hp1 == 0)
        {
            if (transform.position.x >= -5 && transform.position.x <= -4)
            {
                if (transform.position.y >= 0 && transform.position.y <= 2)
                {
                    if (transform.position.z >= 0 && transform.position.z <= 2)
                    {
                        health += 10;
                        healthSlider.value = health;
                        hp1++;
                        GameObject obj = GameObject.Find("Cube (6)");

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
            if (transform.position.x >= 75 && transform.position.x <= 77)
            {
                if (transform.position.y >= 2 && transform.position.y <= 3)
                {
                    if (transform.position.z >= 26 && transform.position.z <= 29)
                    {
                        health += 10;
                        healthSlider.value = health;
                        hp4++;
                        GameObject obj = GameObject.Find("Cube (1002)");

                        if (obj != null)
                        {
                            Destroy(obj);
                        }
                    }
                }
            }
        }
        if (hp2 == 0)
        {
            if (transform.position.x >= 76 && transform.position.x <= 78)
            {
                if (transform.position.y >= 0 && transform.position.y <= 3)
                {
                    if (transform.position.z >= -9 && transform.position.z <= -7)
                    {
                        health += 10;
                        healthSlider.value = health;
                       
                        GameObject obj2 = GameObject.Find("Cube (100)");

                        if (obj2 != null)
                        {
                            hp2++;
                            Destroy(obj2);
                        }
                    }
                }
            }
        }
        if (hp3 == 0)
        {
            if (transform.position.x >= 62 && transform.position.x <= 64)
            {
                if (transform.position.y >= 1 && transform.position.y <= 4)
                {
                    if (transform.position.z >= 11 && transform.position.z <= 13)
                    {
                        health += 10;
                        healthSlider.value = health;

                        GameObject obj3 = GameObject.Find("Cube (101)");

                        if (obj3 != null)
                        {
                            hp3++;
                            Destroy(obj3);
                        }
                    }
                }
            }
        }

    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.name == "ball0")
        {
            health -= 20;
            healthSlider.value = health;
        }
        if (other.gameObject.name == "ball01")
        {
            health -= 20;
            healthSlider.value = health;
        }
        if (other.gameObject.name == "ball02")
        {
            health -= 30;
            healthSlider.value = health;
        }

        if (other.gameObject.name == "Enemy_ball0")
        {
            health -= 4;
            healthSlider.value = health;
        }
        if (other.gameObject.name == "enemyball1")
        {
            health -= 4;
            healthSlider.value = health;
        }
        if (other.gameObject.name == "enemyball22")
        {
            health -= 4;
            healthSlider.value = health;
        }
    }

}
