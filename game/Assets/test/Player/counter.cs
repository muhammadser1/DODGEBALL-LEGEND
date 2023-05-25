using UnityEngine;
using UnityEngine.UI;

public class counter : MonoBehaviour
{
    public int remainingPlayers;
    int flag0 = 0;
    // Start is called before the first frame update
    void Start()
    {
        remainingPlayers = 10;

        // Get the Text component attached to this GameObject
        UnityEngine.UI.Text textComponent = GetComponent<UnityEngine.UI.Text>();

        // Update the initial text
        UpdateRemainingPlayersText(textComponent);
    }

    // Update is called once per frame
    void Update()
    {
        // Update the text

        // Get the Text component attached to this GameObject
        UnityEngine.UI.Text textComponent = GetComponent<UnityEngine.UI.Text>();

        GameObject obj0 = GameObject.Find("door0");
        if (obj0 == null &&flag0==0)
        {
            flag0 = 1;
            remainingPlayers--;
            UpdateRemainingPlayersText(textComponent);
        }
   
    }

    // Update the remaining players text on the Text component
    void UpdateRemainingPlayersText(UnityEngine.UI.Text textComponent)
    {
        textComponent.text = "Remaining Players: " + remainingPlayers.ToString();
    }
}
