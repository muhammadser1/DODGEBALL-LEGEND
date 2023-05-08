using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using static System.Net.Mime.MediaTypeNames;

public class Menu3 : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("Menu 4");

    }
}
