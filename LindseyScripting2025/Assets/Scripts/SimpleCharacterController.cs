using UnityEngine;

[RequireComponent(typeof(CharacterController))] 
public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public float gravity = -9.81f;
    public Transform groundCheck; // Add a Transform to check if the player is grounded
    public float groundDistance = 0.2f; // Adjust the distance for ground checking
    public LayerMask groundLayer; // Layer mask to check for ground collision
    public Animator animator; // Reference to the Animator for triggering animations

    private CharacterController _controller;
    private Vector3 _velocity;
    private Transform _thisTransform;
    private bool isGrounded;
    private bool isFalling;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
        _thisTransform = transform;
    }

    private void Update()
    {
        // Check if the player is grounded
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundLayer);
        
        MoveCharacter();
        ApplyGravity();
        KeepCharacterOnXAxis();
        UpdateFallState();
    }

    private void MoveCharacter()
    {
        // Horizontal movement
        var moveInput = Input.GetAxis("Horizontal");
        var move = new Vector3(x: moveInput, y: 0f, z: 0f) * (moveSpeed * Time.deltaTime);
        _controller.Move(move);

        // Jumping
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump");
            _velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
        }
    }

    private void ApplyGravity()
    {
        // Apply gravity when not grounded
        if (!_controller.isGrounded)
        {
            _velocity.y += gravity * Time.deltaTime;
        }
        else
        {
            // Reset vertical velocity when grounded
            _velocity.y = 0f;
        }

        // Apply the velocity to the controller
        _controller.Move(_velocity * Time.deltaTime);
    }

    private void KeepCharacterOnXAxis()
    {
        // Keeps character on the same z-axis position
        var currentPosition = _thisTransform.position;
        currentPosition.z = 0f;
        _thisTransform.position = currentPosition;
    }

    private void UpdateFallState()
    {
        if (!isGrounded && _velocity.y < 0f && !isFalling)
        {
            // Falling animation
            isFalling = true;
            animator.SetTrigger("Fall");
        }
        else if (isGrounded && isFalling)
        {
            // Is grounded
            isGrounded = true;
            animator.SetTrigger("Idle");
        }
    }
}
