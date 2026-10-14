using UnityEngine;

public class NPCBehavior : MonoBehaviour
{
    public string NPCIdentifier = "Frumpy Enemy #3";
    private void OnCollisionEnter2D(Collision2D collision)
    {
        TriggerBattle();
    }

    void TriggerBattle() 
    {
        GameManager.instance.GameTransition(GameManager.GameStates.Combat);
    }
}
