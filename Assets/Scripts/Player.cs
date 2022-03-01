using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _health = 0;

    public float Health => _health;

    public void TakeDamage(float damage)
    {
        _health -= damage;
    }

    public void Heal(float health)
    {
        _health += health;
    }
}
