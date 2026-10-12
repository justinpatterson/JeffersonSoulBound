using UnityEngine;

public class PlayerCameraBehavior : MonoBehaviour
{
    public Transform playerTarget;
    public Vector3 desiredOffsetFromTarget = new Vector3(0,-1f, 0f);
    [Range(0.1f, 10f)]
    public float snapSpeed = 5f;
    private void Update()
    {
        Vector3 desiredPosition = playerTarget.position + desiredOffsetFromTarget;
        Vector3 nextPosition = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * snapSpeed);
        transform.position = nextPosition;
    }
}
