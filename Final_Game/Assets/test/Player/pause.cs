using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject text;
    void Start()
    {
        text.SetActive(false);

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
                text.SetActive(true);
                Pause();
            
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
                text.SetActive(false);
                Resume();
        }
    }

    void Pause()
    {

        Time.timeScale = 0f;
    }

    void Resume()
    {
        Time.timeScale = 1f;
    }


}
