using UnityEngine;

public class BoxColorChanger : MonoBehaviour
{
/*    public Material newMaterial; // Reference to the new material with the desired color

    private Material originalMaterial; // Reference to the original material of the box
    private Renderer boxRenderer; // Reference to the box's renderer component

    private GameObject player; // Reference to the player GameObject
    private float decreaseAmount = 1f; // The amount to decrease 'y' each time
*/
    private void Start()
    {
    /*    // Get the renderer component of the box
        boxRenderer = GetComponent<Renderer>();

        // Store the original material of the box
        originalMaterial = boxRenderer.material;

        // Find the player GameObject by tag or assign it directly
        player = GameObject.FindGameObjectWithTag("Player");
        //player = GameObject.Find("Player"); // Uncomment this line and comment the above line if you assign the player directly
    */}

    private void Update()
    {
      /*  // Check if the player presses the "1" key
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // Change the material (color) of the box
            boxRenderer.material = newMaterial;

            // Decrease the 'y' position of the player by decreaseAmount
            Vector3 playerPosition = player.transform.position;
            playerPosition.y -= decreaseAmount;

            // Clamp the 'y' position of the player to a minimum of 5
            playerPosition.y = Mathf.Clamp(playerPosition.y, 5f, float.MaxValue);

            // Update the position of the player
            player.transform.position = playerPosition;
        }
        else if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            // Revert back to the original material of the box
            boxRenderer.material = originalMaterial;
        }*/
    }
}
