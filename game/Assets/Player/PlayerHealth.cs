using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class PlayerHealth : MonoBehaviour
{
    int hp1 = 0;
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
        // Check for jump input and decrease health by 10
        if (Input.GetKeyDown(KeyCode.Space))
        {
            health -= 10;
            healthSlider.value = health;
        }

        // Check if an enemy is close and decrease health by 10 if there is
        Collider[] colliders = Physics.OverlapSphere(transform.position, enemyDetectionRadius);
        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag("Enemy"))
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
    }
}
