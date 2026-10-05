using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Vector2 _lastMoveInput;
    Vector2 _lastDesiredInput;

    public Rigidbody2D rb;
    public InputActionReference moveActionReference;

    public bool useLinearVelocity = false;
    public float speed = 2f;

    public Animator animatorReference;
    public string animatorSpeedParameterName;
    public string animatorDirectionParameterName = "Direction";

    private void Awake()
    {

        moveActionReference.action.performed += OnMoveChanged;
        moveActionReference.action.canceled += OnMoveCanceled;
        moveActionReference.action.Enable();
    }


    private void OnMoveCanceled(InputAction.CallbackContext obj)
    {
    }

    private void OnMoveChanged(InputAction.CallbackContext obj)
    {
    }

    private void Update()
    {
        Vector2 moveInput = moveActionReference.action.ReadValue<Vector2>();
        //moveInput.x = left/right
        //moveInput.y = up/down

        Vector2 desiredMovementDirection = moveInput.normalized;
        desiredMovementDirection *= speed;
        desiredMovementDirection *= Time.deltaTime;

        _lastMoveInput = moveInput.normalized;
        _lastDesiredInput = desiredMovementDirection;

        //TODO: also update DIRECTION
        int dir = animatorReference.GetInteger(animatorDirectionParameterName); //last direction
        if ( Mathf.Abs(moveInput.y) > Mathf.Abs(moveInput.x))
        {
            //up or down
            dir = moveInput.y > 0 ? 0 : 2;
        }
        if (Mathf.Abs(moveInput.x) > Mathf.Abs(moveInput.y))
        {
            //left or right
            dir = (moveInput.x > 0) ? 1 : 3;
        } 
        animatorReference.SetInteger(animatorDirectionParameterName, dir);
        animatorReference.SetFloat(animatorSpeedParameterName, moveInput.magnitude > 0.1f ? 1f: 0f);
    }


    private void FixedUpdate()
    {
        if (rb == null)
            return;
        if (useLinearVelocity == false)
            rb.MovePosition(rb.position + _lastDesiredInput);
        else if (useLinearVelocity == true)
            rb.linearVelocity = (_lastMoveInput * speed);
    }
}
