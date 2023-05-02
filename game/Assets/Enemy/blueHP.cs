using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class blueHP : MonoBehaviour
{
    public Slider healthSlider;
    public Slider healthSlider2;
    private int health = 100;
    int x = 0;



    public GameObject smallerEnemyPrefab; 
    private bool hasDivided = false;


    void Start()
    {
    healthSlider.value = health;
}
    void Update()
    {
       if(health<=0 && !hasDivided)
        {

            GameObject enemy1 = Instantiate(smallerEnemyPrefab, transform.position + new Vector3(-0.5f, 0, 0), Quaternion.identity);
            GameObject enemy2 = Instantiate(smallerEnemyPrefab, transform.position + new Vector3(0.5f, 0, 0), Quaternion.identity);
            hasDivided = true;
            gameObject.SetActive(false);
            health = 100;
            healthSlider2.gameObject.SetActive(true);
            healthSlider.gameObject.SetActive(false);

            GameObject obj0 = GameObject.Find("test1");
            GameObject obj01 = GameObject.Find("test2");
            GameObject obj02 = GameObject.Find("test3");
            if (obj0 == null && obj01 == null && obj02 == null)
            {
                GameObject obj = GameObject.Find("door0");
                if (obj != null)
                {
                    Destroy(obj);
                }
            }
        }
    }
void OnCollisionEnter(Collision other)
{
   
    if (other.gameObject.name == "ball0")
    {
        health -= 90;
        healthSlider.value = health;
    }
        if (other.gameObject.name == "ball01")
        {
            health -= 10;
            healthSlider.value = health;
        }
    }
}
