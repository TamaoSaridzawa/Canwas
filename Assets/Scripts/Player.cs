using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private float _minHealth = 0;
    private float _maxHealth = 100;
    public float Health { get; private set; } = 10;

    public event UnityAction<float> HealthChanged;

    public void TakeDamage(float damage)
    {
        Health = Mathf.Clamp(Health - damage, _minHealth, _maxHealth);
        HealthChanged?.Invoke(Health);
    }

    public void Heal(float health)
    {
        Health = Mathf.Clamp(Health + health, _minHealth, _maxHealth);
        HealthChanged?.Invoke(Health);
    }
}
