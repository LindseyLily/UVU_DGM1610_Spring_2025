using Unity.VisualScripting;
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
      //jump animation
      if (Input.GetButtonDown("Jump"))
      {
          animator.SetTrigger("Jump");
      }

      //Double jump animation. No vertical jump yet
        if (Input.GetKeyDown(KeyCode.J))
        {
            animator.SetTrigger("DoubleJump");
        }
        
        //fall animation key trigger doesn't trigger yet
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("Fall");
        }

        //hit animation key trigger
        if (Input.GetKeyDown(KeyCode.H))
        {
            animator.SetTrigger("Hit");
        }
        //Wall jump key trigger
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("WallJump");
        }
    }
}
