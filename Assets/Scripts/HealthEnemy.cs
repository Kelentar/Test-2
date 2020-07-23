using UnityEngine;

public class HealthEnemy : MonoBehaviour
{
    public int health = 2;
    public HealthBar healthBar;
    public int currentHealth;
    public void Start()
    {
        currentHealth = health;
        healthBar.SetMaxHealth(health);
    }
    public void Damage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
