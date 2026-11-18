using UnityEngine;

public class OverworldController : MonoBehaviour
{
    public void ExitRoom() 
    {
        GameManager.instance.GameTransition(GameManager.GameStates.MainMenu);
    }
}
