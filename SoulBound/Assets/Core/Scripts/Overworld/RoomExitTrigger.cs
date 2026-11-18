using UnityEngine;

public class RoomExitTrigger : MonoBehaviour
{
    public OverworldController overworldReference;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerController>()) 
        {
            if (overworldReference != null)
                overworldReference.ExitRoom();
        }
    }
}
