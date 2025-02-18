using UnityEngine;
using UnityEngine.TextCore.Text;

public class HealthSystem : MonoBehaviour
{
    private int currentHP;
    private int maxHP;

    // Sets maximum health
    public HealthSystem(int maxHP = 100)
    {
        this.maxHP = maxHP;
        this.currentHP = maxHP; //Always start at full HP
    }
// Get current HP
    public int GetCurrentHP()
    {
        return currentHP;
    }

    //Handles damage
    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        if (currentHP < 0)
        {
            currentHP = 0; // prevents negative HP
        }
    }

    // Handles healing
    public void Heal(int healAmount)
    {
        currentHP += healAmount;
        if (currentHP > maxHP)
        {
            currentHP = maxHP; // Prevents going over max HP
        }
    }
}
