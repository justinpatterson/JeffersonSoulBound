using UnityEngine;

public class MainMenu_UIPanel : UIPanel
{
    public void OnStartPressed() 
    {
        GameManager.instance.GameTransition(GameManager.GameStates.Overworld);
    }
    public void OnQuitPressed() 
    {
    }
}
