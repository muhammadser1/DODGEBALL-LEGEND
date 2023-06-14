using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using static System.Net.Mime.MediaTypeNames;

public class Menu : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene("BasicPortals");
                                
    }
    public void instructions()
    {
        SceneManager.LoadScene("Menu 3");

    }
    public void Quit()
    {
        UnityEngine.Debug.Log("QUIT!");
        UnityEngine.Application.Quit();

    }
    public void OpenURL()
    {
        UnityEngine.Application.OpenURL("https://github.com/muhammadser1/DODGEBALL-LEGEND");


    }
}
