using UnityEngine;

public class PlayerHP : MonoBehaviour
{
  private HealthSystem healthSystem;

  void Start()
  {
    // Starts HealthSystem at max HP
    healthSystem = new HealthSystem(100);
    
    Debug.Log("Current HP:" + healthSystem.GetCurrentHP());
  }

  //Taking damage
  void TakeDamage(int damage)
  {
    healthSystem.TakeDamage(damage);
    Debug.Log("Current HP after taking damage:" + healthSystem.GetCurrentHP());
  }
  
  //Healing
  void Heal(int healAmount)
  {
    healthSystem.Heal(healAmount);
    Debug.Log("Current HP after healing:" + healthSystem.GetCurrentHP());
  }
}
