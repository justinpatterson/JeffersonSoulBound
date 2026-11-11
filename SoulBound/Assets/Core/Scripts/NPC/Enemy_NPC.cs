using UnityEngine;

public class Enemy_NPC : NPCBehavior
{

    protected override void HandleCollision(Collision2D collision)
    {
        base.HandleCollision(collision);

        TriggerBattle();
    }
    void TriggerBattle()
    {
        GameManager.instance?.GameTransition(GameManager.GameStates.Combat);
    }
}
