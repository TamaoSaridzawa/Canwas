using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private float _minHealth = 0;
    private float _health = 10;
    private float _maxHealth = 30;

    public event UnityAction ChangeHealth;

    public float Health => _health;

    public void TakeDamage(float damage)
    {
        _health = Mathf.Clamp(_health - damage, _minHealth, _maxHealth);
        ChangeHealth?.Invoke();
    }

    public void Heal(float health)
    {
        _health = Mathf.Clamp(_health + health, _minHealth, _maxHealth);
        ChangeHealth?.Invoke();
    }
}
