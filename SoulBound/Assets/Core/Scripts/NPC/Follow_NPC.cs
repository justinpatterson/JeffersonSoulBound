using UnityEngine;

public class Follow_NPC : NPCBehavior
{
    public Transform followTarget;
    public float followDistance;

    public SpriteRenderer followSprite;

    private void Update()
    {
        if (followTarget != null)
        {
            Vector3 targetPosition = followTarget.position + Vector3.up * followDistance;
            Vector3 diff = targetPosition - transform.position;
            float mag = diff.magnitude;
            animController.SetFloat("Speed", mag);

            if (followTarget.GetComponent<PlayerController>()) 
            {
                int dir = followTarget.GetComponent<PlayerController>().lastDir;
                animController.SetInteger("Direction", dir);
            }

            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);

            if(transform.position.y > followTarget.position.y) 
            {
                followSprite.sortingOrder = 1;
            }
            else
            {
                followSprite.sortingOrder = 3;
            }
        }
    }

}
