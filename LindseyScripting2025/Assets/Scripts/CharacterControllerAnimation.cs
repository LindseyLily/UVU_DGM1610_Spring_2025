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
        else
        {
            {
                animator.SetTrigger("Idle");
            }
        }
    
       //doesn't work yet
        if (Input.GetKeyDown("DoubleJump"))
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
    }
}
