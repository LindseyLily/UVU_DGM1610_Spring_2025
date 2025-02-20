using UnityEngine;

public class HealingItem : MonoBehaviour
{
    // Amount of HP restored
    public int healAmount = 25;
    private Animator animator;

    void Start()
    {
        // Animator attached to the item
        animator = GetComponent<Animator>();
    }
    
    //Trigger collision with player
    private void OnTriggerEnter(Collider other)
    {
        // Check if the player has the HealthSystem
        if (other.gameObject.TryGetComponent(out HealthSystem healthSystem))
        {
            //Heals the player
            healthSystem.Heal(healAmount);
            Debug.Log("Health restored: " + healAmount);
            
            // Triggers animation
            if (animator != null)
            {
                animator.SetTrigger("PickUp");
            }
            // Destory item after animation
            Destroy(gameObject, 1f);
        }
    }
}
