using UnityEngine;
[RequireComponent(typeof(CharacterController))] 
public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public float gravity = -9.81f;
    
    private CharacterController controller;
    private Transform thisTransform;
    private Vector3 movementVector = Vector3.zero;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
    }

    private void Update()
    {
        MoveCharacter();
        KeepCharacterOnXAxis();
    }

    private void MoveCharacter()
    {
        movementVector.x = Input.GetAxis("Horizontal");
        movementVector *= (moveSpeed * Time.deltaTime);
        controller.Move(movementVector);
    }

    private void KeepCharacterOnXAxis()
    {
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }
}
