using UnityEngine;

public class Saw : MonoBehaviour
{
    //amount of damage done each hit
    public int damageAmount = 10;
    
    // Collision trigger
    private void OnCollisionEnter(Collision other)
    {
        // Check if the player has a health system
        if (other.gameObject.TryGetComponent(out HealthSystem healthSystem))
        {
            //Deals damage
            healthSystem.TakeDamage(damageAmount);
            Debug.Log("Damage dealt:" + damageAmount);
        }
    }
}
