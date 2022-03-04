using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;

    private Slider _slider;
    private float _speed = 5f;
    private Coroutine _changeJob = null;

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.value = _player.Health;
    }

    private void OnEnable()
    {
        _player.HealthChanged += OnChangeHealth;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnChangeHealth;
    }

    public void OnChangeHealth(float health)
    {
        if (_changeJob != null)
        {
            StopCoroutine(_changeJob);
        }

        StartChange(health);
    }

    private void StartChange(float health)
    {
        _changeJob = StartCoroutine(Change(health));
    }

    private IEnumerator Change(float health)
    {
        while (_slider.value != health)
        {
          _slider.value = Mathf.MoveTowards(_slider.value, health, _speed * Time.deltaTime);

          yield return null;
        }
    }
}
