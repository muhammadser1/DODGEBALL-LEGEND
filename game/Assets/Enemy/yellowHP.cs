using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class yellowHP : MonoBehaviour
{
    public Slider healthSlider;
    // public Slider healthSlider2;
    private int health = 200;
    int x = 0;



    //public GameObject smallerEnemyPrefab; 
    // private bool hasDivided = false;


    void Start()
    {
        healthSlider.value = health;
    }
    void Update()
    {

        if (health <= 0)// && !hasDivided)
        {

            //  GameObject enemy1 = Instantiate(smallerEnemyPrefab, transform.position + new Vector3(-0.5f, 0, 0), Quaternion.identity);
            // GameObject enemy2 = Instantiate(smallerEnemyPrefab, transform.position + new Vector3(0.5f, 0, 0), Quaternion.identity);
            // hasDivided = true;
            //  gameObject.SetActive(false);
            // health = 100;
            // healthSlider2.gameObject.SetActive(true);
            // healthSlider.gameObject.SetActive(false);

            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.name == "ball0")
        {
            health -= 200;
            healthSlider.value = health;
        }
        if (other.gameObject.name == "ball01")
        {
            health -= 200;
            healthSlider.value = health;
        }
        if (other.gameObject.name == "ball02")
        {
            health -= 200;
            healthSlider.value = health;
        }
    }
}
