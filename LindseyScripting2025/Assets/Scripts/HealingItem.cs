using UnityEngine;

public class HealingItem : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Animator attached to the item
        animator = GetComponent<Animator>();
    }
    
    //Trigger collision with player
    private void OnTriggerEnter(Collider other)
    {
            // Triggers animation
            if (animator != null)
            {
                animator.SetTrigger("PickUp");
            }
            // Destory item after animation
            Destroy(gameObject, 1f);
    }
}