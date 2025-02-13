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
      //not yet animated. No vertical jump
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("Jump");
        }
       //double jump animation key trigger. No vertical jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("DoubleJump");
        }
        //fall animation key trigger
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
