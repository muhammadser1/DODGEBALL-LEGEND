using UnityEngine;

public class fix : MonoBehaviour
{
    public Transform player;
    public Transform obj1;

    void Update()
    {
        obj1.position = player.position;
        obj1.rotation = player.rotation;
    }
}
