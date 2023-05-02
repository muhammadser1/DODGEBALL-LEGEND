using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

public class TextDisplay : MonoBehaviour
{
    public UnityEngine.UI.Text text;
    public float displayTime;

    void Start()
    {
        text.enabled = false;
    }

    public void DisplayText(string message)
    {
        StartCoroutine(DisplayTextCoroutine(message));
    }

    private IEnumerator DisplayTextCoroutine(string message)
    {
        text.text = message;
        text.enabled = true;
        yield return new WaitForSeconds(displayTime);
        text.enabled = false;
    }
}
