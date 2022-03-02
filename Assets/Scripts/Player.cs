using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _health = 0;
    private float _maxHealth = 30;

    public float Health => _health;

    public void TakeDamage(float damage)
    {
        if (damage > _health)
        {
            _health = 0;
        }
        else
        {
            _health -= damage;
        }
    }

    public void Heal(float health)
    {
        if (health + _health > _maxHealth)
        {
            _health = _maxHealth;
        }
        else
        {
            _health += health;
        }
    }
}
