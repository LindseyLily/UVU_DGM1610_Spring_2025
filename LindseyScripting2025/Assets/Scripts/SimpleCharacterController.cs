using UnityEngine;
[RequireComponent(typeof(CharacterController))] 
public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public float gravity = -9.81f;
    
    private CharacterController controller;
    private Vector3 velocity;
    private Transform thisTransform;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
    }

    private void Update()
    {
        MoveCharacter();
        ApplyGravity();
        KeepCharacterOnXAxis();
    }
    private void MoveCharacter()
    {
        // Horizonal movement
        var moveInput = Input.GetAxis("Horizontal");
        var move = new Vector3(x: moveInput, y: 0f, z: 0f) * (moveSpeed * Time.deltaTime);
        controller.Move(move);
        
        //jumping
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
        }
    }

    private void ApplyGravity()
    {
        //Apply gravity when not grounded
        if (!controller.isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
        }
        else
            {
                velocity.y = 0f; //Rest velocity when grounded
            }
            
            //Apply the velocity to the controller
            controller.Move(velocity * Time.deltaTime);
    }

    private void KeepCharacterOnXAxis()
    {
        // Keeps character on the same z-axis position
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }
}
