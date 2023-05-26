using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class counter : MonoBehaviour
{
    public int remainingPlayers;
    int flag1 = 0;
    int flag2 = 0;
    int flag3 = 0;
    int flag4 = 0;
    int flag5 = 0;
    int flag6 = 0;
    int flag7 = 0;
    int flag8 = 0;



    // Start is called before the first frame update
    void Start()
    {
        remainingPlayers = 8;

        // Get the Text component attached to this GameObject
        UnityEngine.UI.Text textComponent = GetComponent<UnityEngine.UI.Text>();

        // Update the initial text
        UpdateRemainingPlayersText(textComponent);
    }

    // Update is called once per frame
    void Update()
    {

        if (remainingPlayers == 0)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("Menu 2");

        }
        GameObject obj1 = GameObject.Find("Enemylevel0 (1)");
        GameObject obj2 = GameObject.Find("Enemylevel0");
        GameObject obj3 = GameObject.Find("Enemylevel0 (6)");
        GameObject obj4 = GameObject.Find("E1");
        GameObject obj5 = GameObject.Find("tower_defence");
        GameObject obj6 = GameObject.Find("Enemylevel0 (2)");
        GameObject obj7 = GameObject.Find("Enemylevel0 (4)");
        GameObject obj8 = GameObject.Find("Enemylevel0 (3)");
        UnityEngine.UI.Text textComponent = GetComponent<UnityEngine.UI.Text>();

        
        if (obj1 == null && flag1 == 0)
        {
            flag1 = 1;
            remainingPlayers--;
            UpdateRemainingPlayersText(textComponent);
        }
        if (obj2 == null && flag2 == 0)
        {
            flag2 = 1;
            remainingPlayers--;
            UpdateRemainingPlayersText(textComponent);
        }
        if (obj3 == null && flag3 == 0)
        {
            flag3 = 1;
            remainingPlayers--;
            UpdateRemainingPlayersText(textComponent);
        }
        if (obj4 == null && flag4 == 0)
        {
            flag4 = 1;
            remainingPlayers--;
            UpdateRemainingPlayersText(textComponent);
        }
        if (obj5 == null && flag5 == 0)
        {
            flag5 = 1;
            remainingPlayers--;
            UpdateRemainingPlayersText(textComponent);
        }
        if (obj6 == null && flag6 == 0)
        {
            flag6 = 1;
            remainingPlayers--;
            UpdateRemainingPlayersText(textComponent);
        }
        if (obj7 == null && flag7 == 0)
        {
            flag7 = 1;
            remainingPlayers--;
            UpdateRemainingPlayersText(textComponent);
        }
        if (obj8 == null && flag8 == 0)
        {
            flag8 = 1;
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
