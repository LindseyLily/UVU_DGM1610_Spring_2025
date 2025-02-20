using UnityEngine;

public class Saw : MonoBehaviour
{
    //amount of damage done each hit
    public int damage = 5;
    
    // Collision trigger
    private void OnCollisionEnter(Collision other)
    {
        // Check if the player has a health system
        if (other.gameObject.TryGetComponent(out HealthSystem healthSystem))
        {
            //Deals damage
            healthSystem.TakeDamage(damage);
            Debug.Log("Damage dealt:" + damage);
        }
    }
}
