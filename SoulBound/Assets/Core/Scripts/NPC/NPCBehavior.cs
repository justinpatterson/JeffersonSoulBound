using UnityEngine;

public class NPCBehavior : MonoBehaviour
{
    public string NPCIdentifier = "Frumpy Enemy #3";
    public float speed = 2f;
    public Animator animController;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        HandleCollision(collision);
    }

    protected virtual void HandleCollision(Collision2D collision) 
    {
        
    }



}
