using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    float movSpeed = 5f;

    [SerializeField]
    Rigidbody2D rb;

    [SerializeField]
    InputAction playerControls;

    [SerializeField]
    Vector2 moveDirection = Vector2.zero;

    void OnEnable()
    {
        playerControls.Enable();
    }

    void OnDisable()
    {
        playerControls.Disable();
    }

    void Update()
    {
        moveDirection = playerControls.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveDirection * movSpeed;
    }
}
