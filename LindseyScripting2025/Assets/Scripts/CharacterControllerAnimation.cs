using UnityEngine;

public class CharacterControllerAnimation : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        //cache the Animator component attached to Character Art
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        HandleAnimations();
    }

    private void HandleAnimations()
    {
        //Handle running and idling
        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetTrigger("Run");
        }
        else
        {
            animator.SetTrigger("Idle");
        }
        //Handle jumping
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("Jump");
        }
        //Handle wall jumping
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("WallJump");
        }
    }
}
