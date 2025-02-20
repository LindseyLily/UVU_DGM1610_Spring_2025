using UnityEngine;

public class PlayerHealthSystem : MonoBehaviour
{
    private int currentHP;
    private int maxHP;

    // Sets maximum health, and initializes current health to max
    public PlayerHealthSystem(int maxHP = 100)
    {
        this.maxHP = maxHP;
        this.currentHP = maxHP; // Always start at full HP
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Current HP: " + currentHP);
    }

    // Taking damage
    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        if (currentHP < 0)
        {
            currentHP = 0;  // Prevents negative HP
        }
        Debug.Log("Current HP after taking damage: " + currentHP);
    }

    // Healing
    public void Heal(int healAmount)
    {
        currentHP += healAmount;
        if (currentHP > maxHP)
        {
            currentHP = maxHP;  // Prevents exceeding max HP
        }
        Debug.Log("Current HP after healing: " + currentHP);
    }

    // Get current HP
    public int GetCurrentHP()
    {
        return currentHP;
    }
}

