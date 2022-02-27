using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;

    private float _health = 0;

    public float Health => _health;

    public void TakeDamage(float damage)
    {
        _health -= damage;
        _healthBar.ChangeHealth();
    }

    public void Heal(float health)
    {
        _health += health;
        _healthBar.ChangeHealth();
    }
}
